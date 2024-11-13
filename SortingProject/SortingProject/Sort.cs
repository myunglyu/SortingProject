using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingProject
{
    public class Sort
    {
        public static void MergeSort(int[] arr)
        {
            if (arr.Length > 1)
            {
            int[] a = new int[arr.Length / 2];
            int[] b = new int[arr.Length - arr.Length / 2];

            for (int i = 0; i < a.Length; i++) { a[i] = arr[i]; }
            for (int i = 0; i < b.Length; i++) { b[i] = arr[i + a.Length]; }

                Program.Print(a);
                Program.Print(b);

            MergeSort(a);
            MergeSort(b);
            Merge(a, b, arr);
            }
        }
        public static void Merge(int[] a, int[] b, int[] c)
        {
            int i = 0, j = 0, k = 0;

            while (i < a.Length && j < b.Length)
            {
                if (a[i] < b[j]) { c[k++] = a[i++]; }
                else { c[k++] = b[j++]; }
            }
            while (i < a.Length) { c[k++] = a[i++]; }
            while (j < b.Length) { c[k++] = b[j++]; }

        }


    }
}
