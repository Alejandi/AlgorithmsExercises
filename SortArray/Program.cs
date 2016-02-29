using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArray
{
    class Program
    {
        static int[] a = new int[] { 6, 2, 3, 1, 7, 4, 8, 5 };
        static int n = a.Length;
        static void Main(string[] args)
        {
           
            int left = (n / 2) - 1;
            int right = left + 1;
            for (int i = 0; i <= (n / 2); i++)
            {
                int numeroMayor = HallarNumeroMayorDeLaIzquierda(left);
                Swap(numeroMayor, left);

                int numeroMenor = HallarNumeroMenorDeLaDerecha(right);
                Swap(numeroMenor, right);

                left = left - 1;
                right = right + 1;                
            }

            int[] b = new int[] { };
            b = a;

            //escribirArregloArrEnConsola(a);

           
        }
        static int HallarNumeroMayorDeLaIzquierda(int left)
        {
            int numeroMayor = 0;
            for(int i = 0; i<= left; i++)
            {
                if (a[i] > numeroMayor)
                {
                    numeroMayor = a[i];
                }
            }
            return numeroMayor;
        }

        private static void Swap(int pas1, int pas2)
        {
            int tmp = pas1;
            pas1 = pas2;
            pas2 = tmp;
        }

        static int HallarNumeroMenorDeLaDerecha(int right)
        {
        int numeroMenor = right;
        for (int i = 0; i>=right; i++)
            {
                if (a[i] < numeroMenor)
                {
                    numeroMenor = a[i];
                }            
            }
            return numeroMenor;
        }
        private static void escribirArregloArrEnConsola(int[] arr)
        {
            for (int i = 0; i < n; i++)
            {
                
                Console.Write($"{arr[i]}");
            }
            Console.ReadLine();

        }           
    }
}
