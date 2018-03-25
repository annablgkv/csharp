using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Arrs
    {
        ///////////////////////////////////////////////////   >> задание 1 (старт)
        private Random rnd = new Random();
        ///////////////////////////////////////////////////
        public int[] CreateOneDimArr(int[] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                arr[i] = rnd.Next(0,99);
            }

            return arr;
        }
        ///////////////////////////////////////////////////
        public void PrintArr1(string name, int [] arr)
        {
            Console.Write(name+" = {");
            for(int i=0; i<arr.GetLength(0); i++)
            {
                Console.Write(arr[i] + "; ");
            }
            Console.WriteLine("}");
        }
        ///////////////////////////////////////////////////
        public int[] SumArr(int[] arr1, int[] arr2)
        {
            int[] new_arr = new int[arr1.GetLength(0)];
            for (int i=0; i<new_arr.GetLength(0); i++)
            {
                new_arr[i] = arr1[i] + arr2[i];
            }
            return new_arr;
        }
        ///////////////////////////////////////////////////
        ///////////////////////////////////////////////////   >> задание 1 (конец)

        ///////////////////////////////////////////////////   >> задание 2 (старт)
        public int[,] CreateOneDimArr2(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    arr[i,j] = rnd.Next(0, 99);
                }
            }

            return arr;
        }
        ///////////////////////////////////////////////////
        public void PrintArr2(string name, int[,] arr)
        {
            Console.Write(name+" = {");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.Write("{");
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    Console.Write(arr[i, j] + "; ");
                }
                Console.Write("}");
            }
            Console.WriteLine("}");
        }
        ///////////////////////////////////////////////////
        public int[,] MultMatr(int[,] arr1, int[,] arr2)
        {
            int[,] new_arr = new int[arr1.GetLength(0),arr1.GetLength(1)];
            for (int i = 0; i < new_arr.GetLength(0); i++)
            {
                for (int j = 0; j < new_arr.GetLength(1); j++)
                {
                    new_arr[i,j] = arr1[i,j] * arr2[i,j];
                }
            }
            return new_arr;
        }
        ///////////////////////////////////////////////////
        ///////////////////////////////////////////////////   >> задание 2 (конец)

        ///////////////////////////////////////////////////   >> задание 3 (старт)
        public int[][] CreateOneDimArr3(int[][] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    arr[i][j] = rnd.Next(0, 99);
                }
            }

            return arr;
        }
        ///////////////////////////////////////////////////
        public void PrintArr3(string name, int[][] arr)
        {
            Console.WriteLine(name + " = {");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(" Element({0}): ", i);
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write("{0}{1}", arr[i][j], j == (arr[i].Length - 1) ? "" : " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("}");
        }
        ///////////////////////////////////////////////////   >> задание 3 (конец)

        ///////////////////////////////////////////////////
        ///////////////////////////////////////////////////

        ///////////////////////////////////////////////////     >> лабораторная работа #4
        ///////////////////////////////////////////////////     >> задание 4-1 (старт)
        public void PrintAnyArr(string name, Array arr)
        {
            switch (arr.Rank)
            {
                case 1:
                    Console.Write(name + " = {");
                    for (int i = 0; i < arr.GetLength(0); i++)
                    {
                        var val = arr.GetValue(i);
                        Console.Write(val + "; ");
                    }
                    Console.WriteLine("}");
                    break;
                case 2:
                    Console.Write(name + " = {");
                    for (int i = 0; i < arr.GetLength(0); i++)
                    {
                        Console.Write("{");
                        for (int j = 0; j < arr.GetLength(1); j++)
                        {
                            var val = arr.GetValue(i, j);
                            Console.Write(val + "; ");
                        }
                        Console.Write("}");
                    }
                    Console.WriteLine("}");
                    break;
                default:
                    Console.WriteLine("error");
                    break;
                
            }
        }
        ///////////////////////////////////////////////////     >> задание 4-1 (конец)
        ///////////////////////////////////////////////////     >> задание 4-2 (старт)
        public void PrintAnyArr2(string name, Array arr)
        {
            Console.Write(name + " = {");
            foreach (var val in arr)
            { 
                Console.Write(val + "; ");
            }
            Console.WriteLine("}");
        }
        ///////////////////////////////////////////////////     >> задание 4-2 (конец)
        ///////////////////////////////////////////////////     >> задание 4-3 (старт)
        public void PrintAnyArr3(string name, Object arr)
        {
            Console.WriteLine(name + " = {" + arr + "}");
        }
        ///////////////////////////////////////////////////     >> задание 4-3 (конец)
        ///////////////////////////////////////////////////     >> задание 4-5 (старт)
        public static void PrintArrObj(string name, object[] arr)
        {
            Console.Write(name + " = {");
            foreach (var val in arr)
            {
                Console.Write(val + "; ");
            }
            Console.WriteLine("}");
        }
        ///////////////////////////////////////////////////     >> задание 4-5 (конец)




    }

    class Program
    {
        static void Main(string[] args)
        {
            Arrs temp = new Arrs();
            ///////////////////////////////////////////////////////////////
            int[] A = new int[5],B = new int[5], C = new int[5];
            temp.CreateOneDimArr(A);
            temp.PrintArr1("A", A);

            temp.CreateOneDimArr(B);
            temp.PrintArr1("B", B);

            C = temp.SumArr(A, B);
            temp.PrintArr1("C", C);

            int[] X = { 5, 5, 6, 6, 7, 7 };
            // объявление массивов с отложенной инициализацией 
            int[] U, V;
            U = new int[3];
            for (int i = 0; i < 3; i++) U[i] = i + 1;
            // U = {1,2,3}; // присваивание константного массива недопустимо! 

            V = U;
            V[0] = 9;

            temp.PrintArr1("X", X);
            temp.PrintArr1("U", U);
            temp.PrintArr1("V", V);

            Console.WriteLine("Введите размерность массива:");
            int size = int.Parse(Console.ReadLine());

            int[] D = new int[size];
            temp.CreateOneDimArr(D);
            temp.PrintArr1("D", D);

            ///////////////////////////////////////////////////////////////
            Console.WriteLine();

            int[,] Z = new int[3, 3], L = new int[3,3];
            temp.CreateOneDimArr2(Z);
            temp.CreateOneDimArr2(L);

            temp.PrintArr2("Z", Z);
            temp.PrintArr2("L", L);

            int[,] W = new int[3, 3];
            W = temp.MultMatr(Z, L);
            temp.PrintArr2("W", W);

            ///////////////////////////////////////////////////////////////
            Console.WriteLine();

            int[][] R =
            {
                new int [1],
                new int [2],
                new int [3],
                new int [4],
                new int [5],
                new int [6],
                new int [7],
                new int [8],
                new int [9],
                new int [10]
            };

            temp.CreateOneDimArr3(R);
            temp.PrintArr3("R", R);


            Console.WriteLine("////////////////////////////////////////////////////////////////////");

            temp.PrintAnyArr("A", A);
            temp.PrintAnyArr("Z", Z);
            temp.PrintAnyArr("R", R);

            int[] newA = new int [5];

            Array.Copy(A, newA, 5);
            Array.Reverse(newA);
            // Array.Sort(Z); - нельзя

            temp.PrintAnyArr2("A", newA);
            temp.PrintAnyArr2("Z", Z);
            temp.PrintAnyArr2("R", R);

            temp.PrintAnyArr3("A", A);
            temp.PrintAnyArr3("Z", Z);
            temp.PrintAnyArr3("R", R);
            //////////////////////////////////////////////////////////////////////

            string[] str = { "m", "a", "B", "1997" };

            //temp.PrintArrObj("A", newA); NIЗЯ!!!!!
            Arrs.PrintArrObj("str", str);

        }
    }
}
