using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8_2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Int16 temp1 = 32767;
            Int32 temp2 = 2147483647;
            double temp3 = 30.43256;

            temp1 = temp2; 
            temp1 = temp3;

            temp2 = temp1;
            temp2 = temp3;

            temp3 = temp1;
            temp3 = temp2;

            // все логично!

            Console.WriteLine(temp1);
            Console.WriteLine(temp2);
            Console.WriteLine(temp3);

        }
    }
}
