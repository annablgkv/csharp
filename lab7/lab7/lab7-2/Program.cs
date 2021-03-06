﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7_2
{
    class Rational
    {
        ////////////////////////////////////////////////////////////////////////// > задание #7-2 (старт)
        private int m = 0, n = 0;
        //////////////////////////////////////////////////////////////////////////
        public Rational(int a, int b)
        {
            if (b == 0) { m = 0; n = 1; }
            else
            {
                // приведение знака
                if (b < 0) { b = -b; a = -a; }
                // приведение к несократимой дроби
                int d = nod(a, b);
                m = a / d;
                n = b / d;
            }
        }
        //////////////////////////////////////////////////////////////////////////
        int nod(int m, int n)
        {
            int p = 0;
            m = Math.Abs(m); n = Math.Abs(n);
            if (n > m) {
                p = m;
                m = n;
                n = p;
            }
            do
            {
                p = m % n; m = n; n = p;
            } while (n != 0);
            return (m);
        }
        //////////////////////////////////////////////////////////////////////////
        public override string ToString()
        {
            return m + "/" + n;
        }
        //////////////////////////////////////////////////////////////////////////
        public void PrintRational(string name)
        {
            Console.WriteLine("{0} = {1}", name, ToString());
        }
        ////////////////////////////////////////////////////////////////////////// > задание #7-2 (конец)
        //////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////// > задание #7-3 (старт)
        public Rational Plus(Rational a)
        {
            int u, v;
            u = m * a.n + n * a.m;
            v = n * a.n;
            return (new Rational(u, v));
        } // Plus
        public static Rational operator +(Rational r1, Rational r2)
        {
            return (r1.Plus(r2));
        }
        //////////////////////////////////////////////////////////////////////////
        public Rational Minus(Rational a)
        {
            int u, v;
            u = m * a.n - n * a.m;
            v = n * a.n;
            return (new Rational(u, v));
        } // Minus

        public static Rational operator -(Rational r1, Rational r2)
        {
            return (r1.Minus(r2));
        }
        //////////////////////////////////////////////////////////////////////////

        public Rational Mult(Rational a)
        {
            int u, v;
            u = m * a.m;
            v = n * a.n;
            return (new Rational(u, v));
        } // Mult
        public static Rational operator *(Rational r1, Rational r2)
        {
            return (r1.Mult(r2));
        }
        //////////////////////////////////////////////////////////////////////////
        public Rational Divide(Rational a)
        {
            int u, v;
            u = m * a.n;
            v = n * a.m;
            return (new Rational(u, v));
        } // Divide

        public static Rational operator /(Rational r1, Rational r2)
        {
            return (r1.Divide(r2));
        }
        ////////////////////////////////////////////////////////////////////////// > задание #7-3 (конец)
        //////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////// > задание #7-4 (старт)
        private Rational(int a, int b, string t)
        {
            m = a; n = b;
        }
        //////////////////////////////////////////////////////////////////////////
        //Константы класса 0 и 1 - Zero и One
        public static readonly Rational Zero, One;
        //////////////////////////////////////////////////////////////////////////
        static Rational()
        {
            Console.WriteLine("static constructor Rational");
            Zero = new Rational(0, 1, "private");
            One = new Rational(1, 1, "private");
        } // Статический конструктор
        //////////////////////////////////////////////////////////////////////////
        public static bool operator ==(Rational r1, Rational r2)
        {
            return ((r1.m == r2.m) && (r1.n == r2.n));
        }
        //////////////////////////////////////////////////////////////////////////
        public static bool operator !=(Rational r1, Rational r2)
        {
            return ((r1.m != r2.m) || (r1.n != r2.n));
        }
        //////////////////////////////////////////////////////////////////////////
        public static bool operator <(Rational r1, Rational r2)
        {
            return (r1.m * r2.n < r2.m * r1.n);
        }
        //////////////////////////////////////////////////////////////////////////
        public static bool operator >(Rational r1, Rational r2)
        {
            return (r1.m * r2.n > r2.m * r1.n);
        }
        //////////////////////////////////////////////////////////////////////////
        public static bool operator <(Rational r1, double r2)
        {
            return ((double)r1.m / (double)r1.n < r2);
        }
        //////////////////////////////////////////////////////////////////////////
        public static bool operator >(Rational r1, double r2)
        {
            return ((double)r1.m / (double)r1.n > r2);
        }
        ////////////////////////////////////////////////////////////////////////// > задание #7-4 (конец)
        public void TestRational()
        {
            Rational r1 = new Rational(2, 8);
            Rational r2 = new Rational(2, 5);
            Rational r3 = new Rational(4, 10);
            Rational r4 = new Rational(3, 7);
            Rational r5 = Rational.Zero;
            Rational r6 = Rational.Zero;
            if ((r1 != Rational.Zero) && (r2 == r3)) r5 = (r3 + Rational.One) * r4;
            r6 = Rational.One + Rational.One;
            r1.PrintRational("r1: (2,8)");
            r2.PrintRational("r2: (2,5)");
            r3.PrintRational("r3: (4,10)");
            r4.PrintRational("r4: (3,7)");
            r5.PrintRational("r5: ((r3 +1)*r4)");
            r6.PrintRational("r6: (1+1)");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Rational rat1 = new Rational(0, 0), rat2 = new Rational(1, 1);
            Rational rat3 = new Rational(10, 8), rat4 = new Rational(2, 6);
            Rational rat5 = new Rational(4, -12), rat6 = new Rational(-12, -14);
            rat1.PrintRational("rat1: (0,0)");
            rat2.PrintRational("rat2: (1,1)");
            rat3.PrintRational("rat3: (10,8)");
            rat4.PrintRational("rat4: (2,6)");
            rat5.PrintRational("rat5: (4,-12)");
            rat6.PrintRational("rat6: (-12,-14)");
            //////////////////////////////////////////////////////////////////////////
            Console.WriteLine("////////////////////////////////////////////////////");
            //////////////////////////////////////////////////////////////////////////
            Rational r1 = new Rational(1, 2), r2 = new Rational(1, 3);
            Rational r3, r4, r5, r6;
            r3 = r1 - r2;
            r4 = r1 * r2;
            r5 = r1 / r2;
            r6 = r3 + r4 * r5;
            r1.PrintRational("r1: (1,2)");
            r2.PrintRational("r2: (1,3)");
            r3.PrintRational("r3: (r1-r2)");
            r4.PrintRational("r4: (r1*r2)");
            r5.PrintRational("r5: (r1/r2)");
            r6.PrintRational("r6: (r3+r4*r5)");
            //////////////////////////////////////////////////////////////////////////
            Console.WriteLine("////////////////////////////////////////////////////");
            //////////////////////////////////////////////////////////////////////////
            r1.TestRational();


        }
    }
}
