using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Security.Cryptography.Core;

namespace Csharp.src.IntroductionToAlgorithms
{
    class __231
    {
        public static void MergeSort(int[] A, int p, int q, int r)
        {
            int n1 = q - p + 1;
            int n2 = r - q;

            int[] L = new int[n1 + 1]; // The use of A, L, and R does not match the casing rule of local variable.
            int[] R = new int[n2 + 1]; // The reason why we still use it here is to match the book.

            for (int i = 0; i < n1; ++i) { L[i] = A[p + i]; }
            for (int j = 0; j < n1; ++j) { R[j] = A[q + j + 1]; }

            L[n1] = int.MaxValue; // The infinity in C# is a single (floating) number, it is not possible
            R[n2] = int.MaxValue; // to convert it to an integer, so we use MaxValue here instead.
            int a = 0; // a is i, and b is j in the book.
            int b = 0; // The symbol i and j had been used in the for loop above.

            for (int k = p; k < r; ++k)
            {
                if (L[a] <= R[b])
                {
                    A[k] = L[a];
                    ++a;
                }
                else
                {
                    A[k] = R[b];
                    ++b;
                }
            }
        }
    }
}