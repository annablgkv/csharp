using System;
// лабораторная №1
namespace helloMono
{
	class MainClass
	{
		enum gradus:int // задание 2
		{
			min = 0,
			krit = 72,
			max = 100,
		}
		public static void Main (string[] args)
		{
			//Console.WriteLine ("Hello World!"); // задание 1
			////////////////////////////////////////////////
			//------------------------------------ задание 2
			//int i=10;						//объявление и инициализация целочисленной переменной i
			//Console.WriteLine(i);			//просмотр значения переменной
			//i=100;						//изменение значение переменной
			//Console.WriteLine(i);
			////////////////////////////////////////////////
			//int i;
			//Console.WriteLine(i);
			////////////////////////////////////////////////
			//const int i=10;				//объявление целочисленной константы i
			//Console.WriteLine(i);			//просмотр значения константы
			//i=100;						//ошибка
			//Console.WriteLine(i);
			////////////////////////////////////////////////
			//Console.WriteLine("Минимальная температура = " + (int) gradus.min);
			//Console.WriteLine("Критическая температура = " + (int) gradus.krit);
			//Console.WriteLine("Максимальная температура = " + (int) gradus.max);
			////////////////////////////////////////////////
			//------------------------------------ задание 3
			//int x=6, y=5;
			//Console.WriteLine(x);
			//на экран выводится значение идентификатора х
			//Console.WriteLine("x=" + x + " y=" + y); 	
			/* на экран выводится строка, образованная последовательным слиянием строки  "x=", значения x, строки "у=" и значения у */
			//Console.WriteLine("x={0} y={1}", x, y);	
			/* на экран выводится строка, формат которой задан первым аргументом метода, при этом вместо параметра {0} выводится значение x, а вместо {1} – значение y*/
			////////////////////////////////////////////////
			//int i=3, j=4;
			//Console.WriteLine("{0} {1}", i, j);
			////////////////////////////////////////////////
			Console.WriteLine("\a"); // сигнал ошибки)
			////////////////////////////////////////////////
			//Console.WriteLine("Ура!\nСегодня \"понедельник\"!!!");
			////////////////////////////////////////////////
			//double a= Math.E;
			//Console.WriteLine("E={0,20}", a);
			//Console.WriteLine("E={0,10}", a);
			//Console.WriteLine("E={0:##.###}", a);
			//Console.WriteLine("E={0:.####}", a);
			////////////////////////////////////////////////
			//Console.WriteLine("E={0:.######}", a);
			////////////////////////////////////////////////
			Console.WriteLine("C Format:{0,14:C} \t{0:C2}", 12345.678);
			Console.WriteLine("D Format:{0,14:D} \t{0:D6}", 123);
			Console.WriteLine("E Format:{0,14:E} \t{0:E8}", 12345.6789);
			Console.WriteLine("G Format:{0,14:G} \t{0:G10}", 12345.6789);
			Console.WriteLine("N Format:{0,14:N} \t{0:N4}", 12345.6789);
			Console.WriteLine("X Format:{0,14:X} ", 1234);
			Console.WriteLine("P Format:{0,14:P} ", 0.9);
			////////////////////////////////////////////////
			//string s = Console.ReadLine();
			//Console.WriteLine(s);
			////////////////////////////////////////////////
			//string s = Console.ReadLine();
			//int x = int.Parse(s); //преобразование строки в число
			//Console.WriteLine(x);
			////////////////////////////////////////////////
			//int x = int.Parse(Console.ReadLine()); //преобразование введенной строки в число
			//Console.WriteLine(x);
			////////////////////////////////////////////////
			//double x = double.Parse(Console.ReadLine());
			//Console.WriteLine("X={0:.###}", x);
			///////////////////////////////////////////////////////////////////////
			/*   Написать программу, которая, реализует диалог с пользователем   */
			///////////////////////////////////////////////////////////////////////
			// 1) запрашивает с клавиатуры два целых числа, и выводит на экран сумму данных чисел:
			//int a, b;
			//Console.Write("a = ");
			//a = int.Parse(Console.ReadLine());
			//Console.Write("b = ");
			//b = int.Parse(Console.ReadLine());
			//Console.WriteLine("{0}+{1}={2}", a, b, a+b);
			// 2)  запрашивает с клавиатуры три целых числа, и выводит на экран сумму данных чисел в прямом и обратном порядке:
			//int a, b, c;
			//Console.Write("a = ");
			//a = int.Parse(Console.ReadLine());
			//Console.Write("b = ");
			//b = int.Parse(Console.ReadLine());
			//Console.Write("c = ");
			//c = int.Parse(Console.ReadLine());
			//Console.WriteLine("{0}+{1}+{2}={3}+{4}+{5}", a, b, c, c, b, a);
			// 3) запрашивает с клавиатуры три целых числа, и выводит на экран сумму данных чисел:
			//int a, b, c;
			//Console.Write("a = ");
			//a = int.Parse(Console.ReadLine());
			//Console.Write("b = ");
			//b = int.Parse(Console.ReadLine());
			//Console.Write("c = ");
			//c = int.Parse(Console.ReadLine());
			//Console.WriteLine("{0}+{1}+{2}={3}", a, b, c, a+b+c);
			// 4) запрашивает с клавиатуры два вещественных числа, и выводит на экран произведение данных чисел (вещественные числа выводятся с точностью до 1 знака после запятой):
			//double a, b;
			//Console.Write("a = ");
			//a = double.Parse(Console.ReadLine());
			//Console.Write("b = ");
			//b = double.Parse(Console.ReadLine());
			//Console.WriteLine("{0:.#}*{1:.#}={2:.#}", a, b, a*b);
			// 5) запрашивает с клавиатуры два вещественных числа, и выводит на экран результат деления первого числа на второе (вещественные числа выводятся с точностью до 3 знаков после запятой):
			//double a, b;
			//Console.Write("a = ");
			//a = double.Parse(Console.ReadLine());
			//Console.Write("b = ");
			//b = double.Parse(Console.ReadLine());
			//Console.WriteLine("{0:.###}/{1:.###}={2:.###}", a, b, a/b);
			// 6) запрашивает с клавиатуры три вещественных числа, и выводит на следующее сообщение (вещественные числа выводятся с точностью до 2 знаков после запятой):
			double a, b, c;
			Console.Write("a = ");
			a = double.Parse(Console.ReadLine());
			Console.Write("b = ");
			b = double.Parse(Console.ReadLine());
			Console.Write("c = ");
			c = double.Parse(Console.ReadLine());
			Console.WriteLine("({0:.##}+{1:.##})+{2:.##}={3:.##}+({4:.##}+{5:.##})", a, b, c, a, b, c);
		}
	}
}
