using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Games_Library
{
    public class clsWordsOfWonders {

        static string[,] Words = { { "CAT", "ACT" }, { "ART", "RAT" }, { "TEN", "NET" }, { "WON", "OWN" } };
        public enum enWordIndex { First , Second , Third};


        static public bool IsCorrect(string Word , int Index)
        {
            if (Word == Words[Index , 0] || Word == Words[Index, 1])
                return true;

            return false;
        }

        static public enWordIndex Check(string Word, int Index)
        {
            if (Word == Words[Index , 0])
            {
                return enWordIndex.First;
            }

            if (Word == Words[Index , 1])
            {
                return enWordIndex.Second;
            }

            return enWordIndex.Third;
        }
    }
}
