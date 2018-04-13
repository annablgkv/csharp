using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8_1_4 // если что название должно быть "SortString"
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "Good morning! Little friend! DIE PLS :)";

            string[] s = a.Split(' ');

            Array.Sort(s);

            Console.WriteLine(String.Join(" ", s));

        }
    }
}
