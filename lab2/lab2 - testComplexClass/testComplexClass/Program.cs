using System;
using ComplexClass;

namespace testComplexClass
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Complex t1 = new Complex (1, 1);
			Complex t2 = new Complex (2, 3), t3;
			t3 = Complex.dum(t1, t2);
			Console.WriteLine (t1);
			Console.WriteLine (t2);
			Console.WriteLine (t3);
			//////////////////////////////////////
			// Задания к части №2
			//int i = 2;
			//Console.WriteLine (i);
			//++(++i); ошибка
			//(i--)--; error
			//++(i--); error
			//////////////////////////////////////
			//!(-i); error
			//-(!i); error
			//////////////////////////////////////
			//byte i = -4; error
			//Console.WriteLine (i);
			//////////////////////////////////////
			//Console.WriteLine (1.0/0);
			//Console.WriteLine (1/0); error
			//////////////////////////////////////
			//Console.WriteLine (true<false); error
			//////////////////////////////////////
			//int a=10, b=3;
			//bool t=(a>=b && a!=2*b || a<0);
			//Console.WriteLine (t);
			//////////////////////////////////////
			//int x=5; int y=10;
			//int max = (x > y) ? x : y;
			//Console.WriteLine(max);
			//////////////////////////////////////
			//double x=5.34; double y=10.2;
			//double min = (x < y) ? x : y;
			//Console.WriteLine(min);
			//////////////////////////////////////
			//int x=50;
			//string go = (x < 99 && x > -99) ? "YES" : "NO";
			//Console.WriteLine (go);
			//////////////////////////////////////
			//int a=10, b=3;
			//int t=(a++)-b;
			//b+=t*a;
			//Console.WriteLine(b);
			//////////////////////////////////////
			/* Часть 3. Операторы языка C# */
			//int Ball=0;
			//Console.Write("x= ");
			//float x = float.Parse(Console.ReadLine());
			//Console.Write("y= ");
			//float y = float.Parse(Console.ReadLine());
			//if (x * x + y * y <=1) Ball = 10;		//окружность с радиусом 1
			//else  if (x * x + y * y <= 4) Ball = 5;	//окружность с радиусом 2
			//Console.WriteLine("Ball= "+ Ball);
			//////////////////////////////////////
			//Console.Write("x= ");
			//float x = float.Parse(Console.ReadLine());
			//Console.Write("y=");
			//float y = float.Parse(Console.ReadLine());
			//if (x > y) Console.WriteLine("max= "+x);
			//else Console.WriteLine("max= "+y);
			//////////////////////////////////////
			//int Ball=0;
			//Console.Write("x= ");
			//float x = float.Parse(Console.ReadLine());
			//Console.Write("y= ");
			//float y = float.Parse(Console.ReadLine());
			//if (x * x + y * y <=1) Ball = 10;		//окружность с радиусом 1
			//else  if (x * x + y * y <= 4) Ball = 5;	//окружность с радиусом 2
			//else  if (x * x + y * y <= 6) Ball = 1;	//окружность с радиусом 3
			//Console.WriteLine("Ball= "+ Ball);
			//////////////////////////////////////
			/// #3.3
			//Console.Write("OPER= ");
			//char oper=char.Parse(Console.ReadLine());
			//bool ok=true;
			//Console.Write("A= ");
			//int a=int.Parse(Console.ReadLine());
			//Console.Write("B= ");            
			//int b=int.Parse(Console.ReadLine());
			//float res=0;
			//switch (oper)
			//{
			//case '+': res = a + b; goto case '-';	//1
			//case '-': res = a - b; break;
			//case '*': res = a * b; break;
			//case ':': if (b != 0)
			//	{ 
			//		res = (float)a / b; break;
			//	}
			//else goto default;
			//default: ok = false; break;        
			//}
			//if (ok) Console.WriteLine("{0} {1} {2} = {3}", a, oper, b, res);
			//Console.WriteLine("error");
			/////////////////////////////////////
			//Console.Write("N= ");
			//int n=int.Parse(Console.ReadLine());
			//int i = 1;
			//while (i <= n) {           //пока i меньше или равно n
				//Console.Write(" "+ i++); //выводим i на экран, затем увеличиваем его на 1
				//Console.Write(" "+ i--); // #3.4
			//	Console.Write (" " + i++);
			//	i++;
			//}
			//////////////////////////////////////
			// #3.5
			//Console.Write("N= ");
			//int n=int.Parse(Console.ReadLine());
			//int i = 1;
			//do {
				//Console.Write(" " + i++); //выводим i на экран, затем увеличиваем его на 1
			//	Console.Write(" ", + n--);
			//while (i <= n);           //пока i меньше или равно n
			//} while (i==n);
			//////////////////////////////////////
			// #Домашнее задание №2
			int n=int.Parse(Console.ReadLine());
			//for (int i=1; i < n; i++) {
			//	for (int j=1; j < n; j++) {
			//		Console.Write ("{0};{1} ", i, j);
			//	}
			//	Console.WriteLine ();
			//}
			int flag = 0; int i, j;
			for (i=1; i < n; i++) {
				for (j=1; j < n; j++) {
					if (i == 1 && j == 1) {
						Console.Write ("A");
						flag = 1;
					}
					else if (i == 2 && j == 2) {
						Console.Write ("B");
						flag = 1;
					}
					else if (((j % 2) == 0)&&flag==0) {
						if ((i % 2) == 0) Console.Write ("X");
						else Console.Write (" ");
					} 
					else {
						if (((i % 2) == 0)&&flag==0) Console.Write (" ");
						else Console.Write ("X");
					}
					flag = 0;
				}
				Console.WriteLine ();
			}


		}
	}
}
