using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataArrayDiff
{
    public class Kata
    {
        public static int[] ArrayDiff(int[] a, int[] b)
        {
            var aList = a.ToList();
            var bList = b.ToList();
            var newAList = aList.Where(elementInA => !bList.Contains(elementInA)).ToArray();
            return newAList;
        }

        public static void PrintArray(int[] array)
        {
            foreach (var el in array)
            {
                Console.WriteLine(el);
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var a = new[] { 1, 2, 3, 4, 4 };
            var b = new[] { 4, 1, 5, 6 };
            var c = Kata.ArrayDiff(a, b);
            if (c.Length > 0)
            {
                Kata.PrintArray(c);
            }
            else
                Console.WriteLine("no elements in common");
        }
    }
}
