using System;
using System.Collections.Generic;
using System.Text;

// $G$ RUL-007 (-40) Late submission (2 points per day).

// $G$ SFN-012 (+6) Bonus: Graphics.
// $G$ SFN-012 (+10) Bonus: Events in the Logic layer are handled by the UI.

// $G$ DSN-999 (-10) You should separate your solution into projects - logic and UI

namespace Ex05
{
    public class Program
    {
        public static void Main()
        {
            GameManage newGame = new GameManage();
            newGame.InitializeGame();
        }
    }
}
