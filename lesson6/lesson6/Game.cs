using System;
using System.Runtime.InteropServices;
using SDL2;

namespace Game
{
    class Game
    {
        private static Scene scene = Scene.Instance;

        private static bool InitSDL(ref IntPtr win, ref IntPtr ren)
        {
            SDL.SDL_SetHint(SDL.SDL_HINT_WINDOWS_DISABLE_THREAD_NAMING, "1");
            if (SDL.SDL_Init(SDL.SDL_INIT_VIDEO) != 0)
            {
                Console.WriteLine("SDL_Init Error: {0}", SDL.SDL_GetError());
                return false;
            }

            win = SDL.SDL_CreateWindow("SDL in C#", SDL.SDL_WINDOWPOS_CENTERED, SDL.SDL_WINDOWPOS_CENTERED, scene.WidthInPixels, scene.HeightInPixels, 
                                        SDL.SDL_WindowFlags.SDL_WINDOW_SHOWN | SDL.SDL_WindowFlags.SDL_WINDOW_RESIZABLE);
            if (win == IntPtr.Zero)
            {
                Console.WriteLine("SDL_CreateWindow Error: {0}", SDL.SDL_GetError());
                return false;
            }

            ren = SDL.SDL_CreateRenderer(win, -1, SDL.SDL_RendererFlags.SDL_RENDERER_ACCELERATED| SDL.SDL_RendererFlags.SDL_RENDERER_PRESENTVSYNC);
            if (ren == IntPtr.Zero)
            {
                Console.WriteLine("SDL_CreateRenderer Error: {0}", SDL.SDL_GetError());
                return false;
            }

            SDL_image.IMG_Init(SDL_image.IMG_InitFlags.IMG_INIT_PNG);

            return true;
        }

        private static void DestroySDL(ref IntPtr win, ref IntPtr ren)
        {
            scene.Dispose();

            if (ren != IntPtr.Zero)
            {
                SDL.SDL_DestroyRenderer(ren);
                ren = IntPtr.Zero;
            }

            if (win!=IntPtr.Zero)
            {
                SDL.SDL_DestroyWindow(win);
                win = IntPtr.Zero;
            }
            SDL_image.IMG_Quit();
            SDL.SDL_Quit();
        }

        private static void Update(uint deltaTimeInMilliseconds)
        {
            float deltaTimeInSeconds = deltaTimeInMilliseconds * 0.001f;
            scene.Update(deltaTimeInSeconds);
            //Console.WriteLine("Elapsed time: {0} in seconds.\n", deltaTimeInSeconds);
        }

        private static void Render(ref IntPtr ren)
        {
            scene.Render(ref ren);
            SDL.SDL_RenderPresent(ren);                             //Render present buffer -> display to users
        }

        static void Main(string[] args)
        {
            IntPtr win = IntPtr.Zero;
            IntPtr ren = IntPtr.Zero;
            SDL.SDL_Event e;

            uint frameStart;
            uint frameEnd;
            uint deltaTimeInMilliseconds = 0;

            if (!InitSDL(ref win, ref ren))
            {
                DestroySDL(ref win, ref ren);
                return;
            }

            scene.Init(ref ren);

            bool quit = false;
            while (!quit)
            {
                frameStart = SDL.SDL_GetTicks();
                while (SDL.SDL_PollEvent(out e) != 0)
                {

                    switch (e.type)
                    {
                        case SDL.SDL_EventType.SDL_QUIT:
                            quit = true;
                            break;
                        case SDL.SDL_EventType.SDL_WINDOWEVENT:
                            if (e.window.windowEvent == SDL.SDL_WindowEventID.SDL_WINDOWEVENT_RESIZED)
                            {
                                int newWidth;
                                int newHeight;
                                SDL.SDL_GetWindowSize(win, out newWidth, out newHeight);
                                scene.Resize(newWidth, newHeight);
                            }
                            break;
                        case SDL.SDL_EventType.SDL_KEYDOWN:
                        case SDL.SDL_EventType.SDL_KEYUP:
                            {
                                if (e.key.keysym.sym == SDL.SDL_Keycode.SDLK_q)
                                {
                                    quit = true;
                                }
                                else
                                {
                                    //Pass event to the scene
                                }
                            }
                            break;
                        case SDL.SDL_EventType.SDL_MOUSEBUTTONDOWN:
                        case SDL.SDL_EventType.SDL_MOUSEBUTTONUP:
                        case SDL.SDL_EventType.SDL_MOUSEMOTION:
                            {
                                //Pass event to the scene
                            }
                            break;
                        default:
                            break;
                    }
                }

                SDL.SDL_SetRenderDrawColor(ren, 50, 50, 50, 255);       //Set color to BLACK
                SDL.SDL_RenderClear(ren);                               //Clear color buffer -> BLACK

                Update(deltaTimeInMilliseconds);                        //Using previously computed deltaTimeInMilliseconds -> Variable Frame Rate Game Loop
                Render(ref ren);
                
                frameEnd = SDL.SDL_GetTicks();
                deltaTimeInMilliseconds = frameEnd - frameStart;
            }

            DestroySDL(ref win, ref ren);
        }
    }
}
