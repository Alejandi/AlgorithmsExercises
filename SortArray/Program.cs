
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArray
{
    class Program
    {
        static int[] a = new int[] { 5, 3, 4, 2, 1, 8, 7, 6 };
        //static int[] a = new int[] { 5, 3, 4, 2, 1, 6, 7, 8 };
        //static int[] a = new int[] { 5, 7, 8, 6, 1, 4, 3, 2 };
        static int n = a.Length;
        static int[] b = new int[n];
        static void Main(string[] args)
        {
            int left = (n / 2) - 1;
            int right = left + 1;

            for (int i = 0; i < n / 2; i++)
            {
                int greatIndex = GetGreatesIndexLeftSubArray(left);
                swap(greatIndex, left);

                int lowesIndex = GetLowesIndexRigthSubArray(right);
                swap(lowesIndex, right);

                left--;
                right++;
            }

            printArrr(a);
            completedSorting();
            printArrr(b);
        }
        private static int GetGreatesIndexLeftSubArray(int left)
        {
            int greatesIndex = 0;
            for (int i = 0; i <= left; i++)
            {
                if (a[i] > a[greatesIndex])
                {
                    greatesIndex = i;
                }
            }
            return greatesIndex;
        }

        private static int GetLowesIndexRigthSubArray(int right)
        {
            int lowesIndex = right;
            for (int i = right; i < n; i++)
            {
                if (a[i] < a[lowesIndex])
                {
                    lowesIndex = i;
                }
            }
            return lowesIndex;
        }

        private static void swap(int pos1, int pos2)
        {
            int tmp = a[pos1];
            a[pos1] = a[pos2];
            a[pos2] = tmp;
        }

        private static void completedSorting()
        {

            int k = 0;
            int j = n / 2;

            for (int i = 0; i < n / 2; ++i)
            {
                bool leftIsGreatter = true;
                do
                {

                    if (j >= n)
                    {
                        b[k] = a[i];
                        leftIsGreatter = false;
                    }

                    else if (a[i] < a[j])
                    {
                        b[k] = a[i];
                        leftIsGreatter = false;
                    }

                    else
                    {
                        b[k] = a[j];
                        j++;
                        leftIsGreatter = true;
                    }

                  
                    k++;
                }
                while (leftIsGreatter && k < n);
            }

            while (j < n)
            {
                b[k] = a[j];
                k++;
                j++;
            }
        }

        private static void printArrr(int[] arrayprint)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(arrayprint[i]);
            }
            Console.WriteLine();
            Console.ReadLine();
        }

    }
}
