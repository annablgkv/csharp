using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    // 	Задание 1. Параметры-значения.
    class Example
    {
        // 1.3
        public int x;
        public int y;
        public Example(int x)
        {
            this.x = x;
        }
        //public Example(int x, int y)
        //{
        //    this.x = x;
        //    this.y = y;
        //}
        public static void Init(Example ex1)
        {
            ex1.x = 1;
            ex1.y = 1;
            Console.WriteLine("в методе Init х={0} у={1}", ex1.x, ex1.y);
        }
        // 2,4
        public static void Init2(ref Example ex1)
        {
            ex1.x = 1;
            ex1.y = 1;
            Console.WriteLine("в методе Init х={0} у={1}", ex1.x, ex1.y);
        }
        // 1.1
        public static void Sqr(double a, double b)
        {
            a = Math.Pow(a, 2);
            b = Math.Pow(b, 2);
            Console.WriteLine("В методе Sqr. a = {0}\tb = {1}", a, b);
        }
        // 2.1
        public static void Sqr2(ref double a, ref double b)
        {
            a = Math.Pow(a, 2);
            b = Math.Pow(b, 2);
            Console.WriteLine("В методе Sqr. a = {0}\tb = {1}", a, b);
        }
        // 3
        public static void Out(double value, out int sign, out bool isInteger, out double abs, out double sqr)
        {
            sign = Math.Sign(value);
            isInteger = value % 1 == 0 ? true : false;
            abs = Math.Abs(value);
            sqr = value * value;
        }
        // 4
        public static double Avarge(params int[] arr)
        {
            double av = 0;
            foreach (int elem in arr)
                av += elem;
            return (av / arr.Length);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // ~~~~~~~~~~~~~~~~~~~	Задание 1. Параметры-значения. ~~~~~~~~~~~~~~~~~~~~~~~~~~
            Console.WriteLine("\n\n ---[ Задание #1 ]---------------------------------------------------");

            double dd1 = 33, dd2 = 21;
            Console.WriteLine("dd1 = {0}\tdd2 = {1}\n", dd1, dd2);
            // применим наш метод
            Example.Sqr(dd1, dd2);
            Console.WriteLine("dd1 = {0}\tdd2 = {1}\n", dd1, dd2);
            // и еще раз применим
            Example.Sqr(dd1 * 2, dd2 * 2);
            Console.WriteLine("dd1 = {0}\tdd2 = {1}\n", dd1, dd2);

            // 1.3
            Example ex1 = new Example(2);
            Console.WriteLine("В методе Main: ex1.x = {0}\tex1.y = {1}", ex1.x, ex1.y);
            Example.Init(ex1);
            Console.WriteLine("В методе Main: ex1.x = {0}\tex1.y = {1}", ex1.x, ex1.y);

            // 2.3
            Console.WriteLine("\n\n ---[ Задание #2 ]---------------------------------------------------\n", dd1, dd2);
            // применим наш метод
            Example.Sqr2(ref dd1, ref dd2);
            Console.WriteLine("В методе Main: dd1 = {0}\tdd2 = {1}\n", dd1, dd2);
            Example ex2 = new Example(3);
            Console.WriteLine("В методе Main: ex2.x = {0}\tex2.y = {1}", ex2.x, ex2.y);
            Example.Init2(ref ex2);
            Console.WriteLine("В методе Main: ex2.x = {0}\tex2.y = {1}", ex2.x, ex2.y);

            double c = 5;
            Example.Sqr2(ref dd1, ref c);

            // 3
            Console.WriteLine("\n\n ---[ Задание #3 ]---------------------------------------------------");

            double dout1 = 42, dout2 = -12.67;
            double d_abs, d_sqr;
            int i_sign; bool d_isInteger;

            Example.Out(dout1, out i_sign, out d_isInteger, out d_abs, out d_sqr);
            Console.WriteLine("В методе Main: dout1 = {0} dout2 = {1} i_sign = {2} d_isInteger = {3} d_abs = {4} d_sqr = {5}\n", dout1, dout2, i_sign, d_isInteger, d_abs, d_sqr);
            Example.Out(dout2, out i_sign, out d_isInteger, out d_abs, out d_sqr);
            Console.WriteLine("В методе Main: dout1 = {0} dout2 = {1} i_sign = {2} d_isInteger = {3} d_abs = {4} d_sqr = {5}\n", dout1, dout2, i_sign, d_isInteger, d_abs, d_sqr);

            // 4
            Console.WriteLine("\n\n ---[ Задание #4 ]---------------------------------------------------");

            short z = 1, e = 12;
            byte v = 107;
            Console.WriteLine("Среднее значение =" + Example.Avarge(z, e, v));


            Console.ReadLine();
        }
    }
}
