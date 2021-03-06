﻿using System;
using System.Collections.Generic;
using System.Drawing;

namespace Nemo
{
    class TileRow
    {
        private readonly int RowIndex;
        private readonly int RowLength;
        public int Y { get; private set; }
        private readonly int TileWidth;
        private readonly int TileHeight;
        private Color Background;

        public List<Tile> Tiles { get; private set; }
        public int RedTileIndex { get; private set; }

        public TileRow(int rowIndex, int tileCount, int tileWidth, int tileHeight)
        {
            this.RowIndex = rowIndex;
            this.RowLength = tileCount;
            this.Y = -tileHeight;

            this.TileHeight = tileHeight;
            this.TileWidth = tileWidth;

            this.Background = System.Drawing.SystemColors.ControlDark;

            this.GenerateTileRow();
        }

        private void GenerateTileRow()
        {
            this.Tiles = new List<Tile>();

            Random rdm = new Random();
            this.RedTileIndex = rdm.Next(0, this.RowLength);

            for(int i =0; i<this.RowLength; i++)
            {
                int tileValue = i + this.RowIndex * this.RowLength + 1;
                int tileX = i * this.TileWidth;
                Tile newTile = new Tile(
                    tileValue,
                    tileX,
                    -this.TileHeight,
                    this.TileWidth,
                    this.TileHeight
                    );

                if(i == this.RedTileIndex)
                {
                    newTile.Background = Color.Red;
                }

                this.Tiles.Add(newTile);
            }
        }

        public Color GetBackground()
        {
            return this.Background;
        }

        public void MoveDown(int dY)
        {
            this.Y += Math.Abs(dY);
            this.Tiles.ForEach(t => t.MoveDown(dY));
        }
    }
}
