using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextGame.Character;
using TextGame.Levels;

namespace TextGame.GameStart
{
    public static class Run
    {
        public static void StartGame()
        {
            Player.Initialize();
            Intro.Upstart();
        }
    }
}
