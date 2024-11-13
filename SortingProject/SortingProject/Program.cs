using System.ComponentModel.Design;

namespace SortingProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 1, 5, 4, 2, 34, 67, 86, 85, 34, 23, 64, 73, 76 };
            Program.Print(arr);
            int[] a = { 1, 3, 5, 7, 12, 13 };
            int[] b = { 2, 4, 6, 8, 34, 35 };
            int[] c = new int[a.Length + b.Length];
            Sort.Merge(a, b, c);
            Print(c);
            Sort.MergeSort(arr);
            Print(arr);

        }
        public static void Print(int[] arr)
        {
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
