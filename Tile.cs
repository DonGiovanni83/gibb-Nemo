using System;
using System.Drawing;

namespace Nemo
{
    class Tile
    {
        
        private readonly int Value;
        private int Y;
        private readonly int X;
        private Color Background;

        public Tile(int value, int x, int y)
        {
            this.Value = value;
            this.X = x;
            this.Y = y;
            this.Background = System.Drawing.SystemColors.ControlDark;
            this.Background = System.Drawing.SystemColors.ControlDark;
        }   

        public int GetY()
        {
            return this.Y;
        }
        
        public int GetX()
        {
            return this.X;
        }

        public int GetValue()
        {
            return this.Value;
        }

        public Color GetBackground()
        {
            return this.Background;
        }

        public void MoveDown(int dY)
        {
            this.Y += dY;
        }

        public Tile Clone()
        {
            return new Tile(
                this.Value,
                this.X,
                this.Y
                );
        }
    }
}
