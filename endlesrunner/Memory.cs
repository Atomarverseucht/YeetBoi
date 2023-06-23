using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace endlesrunner
{
    internal class Memory
    {
        public static int coinvalue = 0;
        public static int selectedSkin = 0;
        public static int selectedBackground = 0;
        public static bool mode = false;
        public static bool language = false;
        public static int hs_score = 0;
        public static int volume = 1;

        public static bool[,] ownedItems = { { true, false }, { true, false } };
     }   
}
