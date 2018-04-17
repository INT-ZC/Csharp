using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Security.Cryptography.Core;

namespace Csharp.src.IntroductionToAlgorithms
{
    class __232
    {
        public static void MergeSort(int[] A, int p, int r)
        {
            if (p < r)
            {
                int q = (p + r) / 2;
                MergeSort(A, p, q);
                MergeSort(A, q + 1, r);
                Merge(A, p, q, r);
            }
        }

        public static void Merge(int[] A, int p, int q, int r)
        {
            int[] tmp = new int[A.Length];
            int i = p;
            int left = p;
            int right = q + 1;

            while (p <= q && right <= r)
            {
                if (A[p] <= A[right]) { tmp[left++] = A[p++]; }
                else { tmp[left++] = A[right++]; }
            }
            while (right <= r) { tmp[left++] = A[right++]; }
            while (p <= q) { tmp[left++] = A[p++]; }
            while (i <= r) { A[i] = tmp[i++]; }
        }
    }
}