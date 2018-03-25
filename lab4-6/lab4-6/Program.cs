using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_6
{
    class YaNeZnau
    {
        private Random rnd = new Random();

        public void createArr(string name, int[] arr, int start, int end)
        {
            for (int i=start; i<end; i++)
            {
                arr[i] = rnd.Next(0, 99);
            }
        }

        public void showArr(string name, int[] arr)
        {
            Console.Write(name + ": ");
            foreach (int val in arr)
            {
                Console.Write(val + " ");
            }
            Console.WriteLine();
        }

        public void showArr2(string name, int[] arr, int start)
        {
            if (start < arr.GetLength(0))
            {
                for (int i = start; i < arr.GetLength(0); i++)
                {
                    Console.Write(arr[i] + "; ");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("ERROR");
            }
            

            
        }

        public void sumArr(int[] arr1, int[] arr2)
        {
            int[] res = new int[arr2.GetLength(0)];
            int n=0;
            for (int i=0; i<arr1.GetLength(0); i++)
            {
                for(int j=0; j<arr2.GetLength(0); j++)
                {
                    if ((i==j) && (arr1[i]!=0) && (arr2[j] != 0))
                    {
                        res[n] = arr1[i] + arr2[j];
                        n++;
                    }
                }
            }
            showArr("resSum", res);
        }

        public void minusArr(int[] arr1, int[] arr2)
        {
            int[] res = new int[arr2.GetLength(0)];
            int n = 0;
            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(0); j++)
                {
                    if ((i == j) && (arr1[i] != 0) && (arr2[j] != 0))
                    {
                        res[n] = arr1[i] - arr2[j];
                        n++;
                    }
                }
            }
            showArr("resMinus", res);
        }

        public void skolArr(int[] arr1, int skol)
        {
            int[] res = new int[arr1.GetLength(0)];
            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                res[i] = arr1[i] * skol;
            }
            showArr("resSkol", res);
        }

        public void noskolArr(int[] arr1, int skol)
        {
            int[] res = new int[arr1.GetLength(0)];
            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                res[i] = arr1[i] / skol;
            }
            showArr("resSkol", res);
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            YaNeZnau temp = new YaNeZnau();

            int len1 = 10;
            int len2 = 15;

            int start1 = 2;
            int start2 = 3;

            int end1 = 9;
            int end2 = 7;


            int[] arr1 = new int[len1];
            int[] arr2 = new int[len2];


            temp.createArr("arr1", arr1, start1, end1);
            temp.createArr("arr2", arr2, start2, end2);


            temp.showArr("arr1", arr1);
            temp.showArr("arr2", arr2);

            temp.sumArr(arr1, arr2);
            temp.minusArr(arr1, arr2);

            temp.skolArr(arr1, 6);
            temp.noskolArr(arr1, 3);

            temp.showArr2("arr", arr2, 5);


        }
    }
}
