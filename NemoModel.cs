﻿using System;
using System.Collections.Generic;

namespace Nemo
{
    class NemoModel
    {
        private int gameCount = 0;
        private int points = 0;
        private int speed = 5;
        private int speedIncrement = 5;
        private int rowIndex = 0;
        private List<Tile> gameBoard = new List<Tile>(); 

        public void CreateNewTileRow()
        {
            this.rowIndex++;
            Tile newTile = new Tile(this.rowIndex, 0, -92);
            this.gameBoard.Add(newTile);
        }

        public void RemoveTile(Tile tile)
        {
            this.gameBoard.Remove(tile);
        }
        public List<Tile> GetGameBoard()
        {
            return this.gameBoard;
        }
        public List<Tile> GetGameBoardCopy()
        {
            List<Tile> copy = new List<Tile>();
            this.gameBoard.ForEach(tile => { copy.Add(tile); });
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
                $"Du hast {this.points} Punkte und eine Geschwindigkeit von {this.speed} erreicht"; 
        }
        
        public String GetInfoErrorMissed() 
        {
            return $"Du hast in der untersten Reihe nicht geklickt - Die Spielrunde ist vorüber\n" +
                  $"Du hast {this.points} Punkte und eine Geschwindigkeit von {this.speed} erreicht";
        } 

        public String GetInfoErrorStopped() 
        {
            return $"Du hast das Spiel gestoppt - Die Spielrunde ist vorüber\n" +
                  $"Du hast {this.points} Punkte und eine Geschwindigkeit von {this.speed} erreicht";
        }     
        
        public void IncreaseGameCount()
        {
            this.gameCount++;
        }
    }
}
