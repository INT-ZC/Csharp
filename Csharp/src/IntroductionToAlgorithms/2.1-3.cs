using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.src.IntroductionToAlgorithms
{
    class __213
    {
        public static string GetIndex(int[] array, int value)
        {
            for (int i = 0; i < array.Length; ++i)
            {
                if (value == array[i]) { return i.ToString(); }
                else return "NIL";
            }
            return "NIL";
        }
    }
}
