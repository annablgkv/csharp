using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8_1_3 // если что название должно быть "List-Value-Types"
{

    class Program
    {
        static void Main(string[] args)
        {
            SByte a = 0;
            Byte b = 0;
            Int16 c = 0;
            Int32 d = 0;
            Int64 e = 0;
            String f = "";
            Exception ex = new Exception();

            Object[] types = { a, b, c, d, e, f, ex };

            foreach (object o in types)
            {
                Console.WriteLine(o.GetType() + ": " + o.GetType().IsValueType);
            }

        }
    }
}
