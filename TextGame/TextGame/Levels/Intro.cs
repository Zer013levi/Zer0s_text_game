using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextGame.Character;

namespace TextGame.Levels
{
    public static class Intro
    {
        public static void Upstart()
        {
            Console.WriteLine("hi");
            Downstart();
        }
        public static void Downstart()
        {
            Console.WriteLine(Player.HP);
            Player.HP = -10;
        }

    }
}
