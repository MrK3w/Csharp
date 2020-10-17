using System;
using System.Collections.Generic;
using System.Text;

namespace lesson5
{
    class Tetromino
    {
        protected int x { get; set; }
        protected int y { get; set; }
        


        public Tetromino(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

    }
}
