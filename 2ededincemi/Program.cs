using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ededincemi
{
    class Program
    {
        public static int topla(int eded1, int eded2)
        {
            int netice = eded1 + eded2;
            return netice;
        }
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int result = topla(a, b);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
