using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionAndRecursiveMethodsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Recursive recursive = new Recursive();
            int result = recursive.PowerOfNum(11, 3);
            Console.WriteLine(result);

            string text1 = "Julius Caesar";
            Console.WriteLine(text1.CheckSpace());

            Console.ReadLine();

        }
    }

    public class Recursive
    {
        public int PowerOfNum(int num, int power)
        {
            if (power == 1)
            {
                return num;
            }
            return PowerOfNum(num, power - 1) * num;
        }
    }

    public static class Extension
    {
        public static bool CheckSpace(this string text)
        {
            return text.Contains(" ");
        }
    }
}
