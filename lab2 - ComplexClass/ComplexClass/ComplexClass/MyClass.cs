using System;

namespace ComplexClass
{
	public class Complex
	{
		double re, im;

		public Complex (double r, double i)
		{
			re = r;
			im = i;
		}

		public static Complex dum(Complex c1, Complex c2)
		{
			return new Complex (c1.re + c2.re, c1.im + c2.im);
		}

		public String toString()
		{
			return "Complex: " + re + " " + im;
		} 
	}
}

