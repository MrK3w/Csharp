using System;
using System.Collections.Generic;
using System.Text;

namespace game
{
    interface IRenderable
    {
        int Width { get; set; }
        int Height { get; set; }
        void Init(IntPtr renderer);
        void Update(float delta_time);
        void Resize(int width, int height);
        void Render(IntPtr renderer);
    }

    abstract class Entity : IRenderable
    {
        private IntPtr array_intptr;
        public int X { get; set; }
        public int Y { get; set; }
        public int Rotation { get; set; }

        public int Width { get; set; }
        public int Height { get; set; }

        public int width
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public void Init(IntPtr renderer)
        {
        }

        public void Render(IntPtr renderer)
        {
        }

        public void Resize(int width, int height)
        {
        }

        public void Update(float delta_time)
        {
        }

        public Entity()
        {

        }
    }

    abstract class DynamicEntity : Entity
        {
            private int SpeedFactor { get; set; }

            public DynamicEntity() : base()
            {

            }
        }

       
    }

