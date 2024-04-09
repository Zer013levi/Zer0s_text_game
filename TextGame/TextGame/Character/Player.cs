using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGame.Character
{
    public static class Player
    {
        public static string Name { get; set; }

        public static int HP { get; set; }

        public static int Mana {  get; set; }

        public static bool isInitialize;
        public static void Initialize()
        {
            if (isInitialize)
            {
                return;
            }
            else
            {
                Name = "Malik";
                HP = 100;
                Mana = 100;

                isInitialize = true;
            }

        }
    }
}
