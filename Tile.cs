using System;
using System.Drawing;

namespace Nemo
{
    class Tile
    {

        public int Value { get; }
        public int Y { get; private set; }
        public Color Background { get; }
        public int Width { get; }
        public int Height { get; }
        public int X { get;}

        public Tile(int value, int x, int y, int width, int height)
        {
            this.Value = value;
            this.X = x;
            this.Y = y;
            this.Width = width;
            this.Height = height;
            this.Background = System.Drawing.SystemColors.ControlDark;
            this.Background = System.Drawing.SystemColors.ControlDark;
        }   

        public void MoveDown(int dY)
        {
            this.Y += dY;
        }
    }
}
