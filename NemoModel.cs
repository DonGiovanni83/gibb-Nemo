using System;
using System.Collections.Generic;
using System.Text;

namespace Nemo
{
    class NemoModel
    {
        private int gameCount = 0;
        private int points = 0;
        private int speed = 5;
        private int speedIncrement = 5;

        private String GetInfoIdle() 
        { 
            return $"Klicke auf Start\ndas ist die {this.gameCount} Spielrunde"; 
        }

        private String GetInfoRunning() 
        { 
            return "Klicke auf die roten Rechtecke"; 
        }

        private String GetInfoErrorClick() 
        { 
            return $"Du hast das falsche Feld geklickt - Die Spielrunde ist vorüber\n" +
                $"Du hast {this.points} Punkte und eine Geschwindigkeit von {this.speed} erreicht"; 
        }
        
        private String GetInfoErrorMissed() 
        {
            return $"Du hast in der untersten Reihe nicht geklickt - Die Spielrunde ist vorüber\n" +
                  $"Du hast {this.points} Punkte und eine Geschwindigkeit von {this.speed} erreicht";
        } 

        private String GetInfoErrorStopped() 
        {
            return $"Du hast das Spiel gestoppt - Die Spielrunde ist vorüber\n" +
                  $"Du hast {this.points} Punkte und eine Geschwindigkeit von {this.speed} erreicht";
        }       
    }
}
