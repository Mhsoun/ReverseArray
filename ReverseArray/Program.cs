using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            Console.WriteLine("Enter 5 intergers and press enter after each");
            _ = int.TryParse(Console.ReadLine(), out a[0]);
            _ = int.TryParse(Console.ReadLine(), out a[1]);
            _ = int.TryParse(Console.ReadLine(), out a[2]);
            _ = int.TryParse(Console.ReadLine(), out a[3]);
            _ = int.TryParse(Console.ReadLine(), out a[4]);

            Console.WriteLine("your array is:");
            Console.WriteLine("[{0}]", string.Join(", ", a));//print Array in a style
           
            Array.Reverse(a);  //reverse Array
            Console.WriteLine("your reversed array is");
            Console.WriteLine("[{0}]", string.Join(", ", a));

        }
    }
}
