using System;
using System.Collections.Generic;
using System.Text;
using SDL2;

namespace Game
{
    //Thread safe Singleton Design Pattern
    sealed class Scene : IDisposable
    {
        #region Singleton Implementation
        private static readonly object InstanceLock = new object();
        private static Scene instance = null;
        public static Scene Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (InstanceLock)
                    {
                        if (instance == null)
                            instance = new Scene();
                    }
                }
                return instance;
            }
        }
        #endregion

        #region Fields
        public int WidthInPixels { get; set; } = 800;
        public int HeightInPixels { get; set; } = 600;
        private List<IntPtr> Textures { get; set; }
        //TODO: Create List of Entities
        #endregion

        #region Constructor and Finalizer
        private Scene()
        {
            Textures = new List<IntPtr>(16);
            //TODO: Initialize list of entities
        }

        ~Scene()
        {
            Dispose(false);
        }
        #endregion

        #region Private Methods
        private bool InitTextures(ref IntPtr renderer)
        {
            if (renderer == IntPtr.Zero) return false;

            try
            {
                List<string> texturesToLoad = new List<string> 
                    { 
                      "./assets/covid.png"
                    };
                foreach (string s in texturesToLoad)
                {
                    IntPtr tex = SDL_image.IMG_LoadTexture(renderer, s);
                    if (tex == IntPtr.Zero)
                    {
                        Console.WriteLine("SDL_CreateTexture Error: {0}", SDL.SDL_GetError());
                        return false;
                    }
                    Textures.Add(tex);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            return true;
        }

        private bool InitEntities(ref IntPtr renderer)
        {
            //TODO
            return true;
        }

        #endregion

        #region Public Methods
        public bool Init(ref IntPtr renderer)
        {
            if (!InitTextures(ref renderer)) return false;
            if (!InitEntities(ref renderer)) return false;
            return true;
        }

        public void Render(ref IntPtr renderer)
        {

        }

        public void Update(float deltaTimeInSeconds)
        {

        }

        public void Resize(int windowWidth, int windowHeight)
        {

        }
        #endregion

        #region IDisposable
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Dispose(bool isManualDisposing)
        {
            //TODO: Clear List of entities

            //Release Unmanaged Resources
            foreach(IntPtr t in Textures)
            {
                if (t != IntPtr.Zero)
                {
                    SDL.SDL_DestroyTexture(t);
                }
            }

            if (isManualDisposing)
                Textures.Clear();
        }
        #endregion
    }
}
