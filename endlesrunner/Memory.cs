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
        public static bool[,] ownedItems = { { true, false }, { true, false } };
        public static string name = "YeetBoi"; 

        public static string[] encodeVariables()
        {
            string[] code = new string[9];
            if (coinvalue > 999)
            {
                coinvalue = 999;
            }
            code[0] = name;
            code[1] = coinvalue.ToString("D3");
            code[2] = selectedSkin.ToString();
            code[3] = selectedBackground.ToString();
            code[4] = mode?"1":"0";
            code[5] = language ? "1" : "0";
            code[6] = hs_score.ToString();
            code[7] = ownedItems[0,1] ? "1" : "0";
            code[8] = ownedItems[1,1] ? "1" : "0";
            return code;
        }

        public static void decodeVariables(string[] variables)
        {
            name = variables[0];
            coinvalue = Int32.Parse(variables[1]);
            selectedSkin = Int32.Parse(variables[2]);
            selectedBackground = Int32.Parse(variables[3]);
            mode = convertStringToBool(variables[4]);
            language = convertStringToBool(variables[5]);
            hs_score = Int32.Parse(variables[6]);
            ownedItems[0,1] = convertStringToBool(variables[7]);
            ownedItems[1,1] = convertStringToBool(variables[8]);
        }

        public static bool convertStringToBool(string value)
        { 
            if (value == "1") 
            { 
                return true;
            }
            else
            {
                return false;
            }
        }
     }   
}
