﻿using System;
using System.Collections.Generic;

namespace Nemo
{
    class NemoModel
    {
        private int gameCount = 0;
        private int Points = 0;
        private int speed = 5;
        private int speedIncrement = 5;
        private int rowIndex = 0;
        public List<TileRow> GameBoard { get; private set; } = new List<TileRow>();
        public int TileRowsCount { get; private set; }
        public int TileColumnsCount { get; private set; }
        public int TileWidth { get; private set; }
        public int TileHeight { get; private set; }

        internal void CreateNewBoard(int tileRowsCount, int tileColumnsCount, int boardWidth, int boardHeight)
        {
            this.TileRowsCount = tileRowsCount;
            this.TileColumnsCount = tileColumnsCount;
            int width = boardWidth / tileColumnsCount;
            int height = boardHeight / tileRowsCount;
            this.TileWidth = width;
            this.TileHeight = height;
        }

        public void CreateNewTileRow()
        {
            TileRow newTileRow = new TileRow(this.rowIndex, 5, this.TileWidth, this.TileHeight );
            this.rowIndex++;
            this.GameBoard.Add(newTileRow);
        }

        public void RemoveTileRow(TileRow tileRow)
        {
            this.GameBoard.Remove(tileRow);
        }
        public List<TileRow> GetGameBoardCopy()
        {
            List<TileRow> copy = new List<TileRow>();
            this.GameBoard.ForEach(tileRow => { copy.Add(tileRow); });
            return copy ;
        }
        public int GetGameSpeed()
        {
            return this.speed;
        }

        public int GetRowIndex()
        {
            return this.rowIndex;
        }

        public String GetInfoIdle() 
        { 
            return $"Klicke auf Start\ndas ist die {this.gameCount} Spielrunde"; 
        }

        public String GetInfoRunning() 
        { 
            return "Klicke auf die roten Rechtecke"; 
        }

        public String GetInfoErrorClick() 
        { 
            return $"Du hast das falsche Feld geklickt - Die Spielrunde ist vorüber\n" +
                $"Du hast {this.Points} Punkte und eine Geschwindigkeit von {this.speed} erreicht"; 
        }
        
        public String GetInfoErrorMissed() 
        {
            return $"Du hast in der untersten Reihe nicht geklickt - Die Spielrunde ist vorüber\n" +
                  $"Du hast {this.Points} Punkte und eine Geschwindigkeit von {this.speed} erreicht";
        } 

        public String GetInfoErrorStopped() 
        {
            return $"Du hast das Spiel gestoppt - Die Spielrunde ist vorüber\n" +
                  $"Du hast {this.Points} Punkte und eine Geschwindigkeit von {this.speed} erreicht";
        }     
        
        public void IncreaseGameCount()
        {
            this.gameCount++;
        }

        public void IncreaseSpeed()
        {
            this.speed += this.speedIncrement;
        }

        public void AddPoints(int points)
        {
            this.Points += points;
        }
    }
}
