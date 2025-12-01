using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieLogicLibrary;

namespace MainApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MovieInvoke(); -----> Movie Method Invoke
            //ArraySort(arr); -----> Array Sort Method Invoke
            //ArrayCopy(arr); -----> Array Copy Method Invoke
            //ArrayContains(); -----> Array Contains Method Invoke
            int[] arr = new int[] { 5, 3, 8, 1, 4 };

        }

        private static void ArrayContains()
        {
            string[] str = new string[] { "Apple", "Orange", "Banana", "Grapes" };

            if (str.Contains("Banana"))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        private static void ArrayCopy(int[] arr)
        {
            int[] destArr = new int[5];
            Array.Copy(arr, destArr, 5);

            Console.WriteLine("Destination Array : ");
            foreach (var item in destArr)
            {
                Console.Write(item + " ");
            }
        }

        private static void ArraySort(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\nSorted Array : ");
            Array.Sort(arr);

            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
        }

        private static void MovieInvoke()
        {
            Movie m = new Movie();
            double amt = m.BookTicket("Avatar", 3, SeatType.Recliner);
            Console.WriteLine(amt);
        }
    }
}
