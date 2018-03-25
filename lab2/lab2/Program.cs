using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] desk = new char[8,8];
            
            for (int i=0; i<8; i++)
            {
                for (int j=0; j<8; j++)
                {
                    if ((j % 2) == 0)
                    {
                        if ((i % 2) == 0) desk[i, j] = 'X';
                        else desk[i, j] = ' ';
                    }
                    else
                    {
                        if ((i % 2) == 0) desk[i, j] = ' ';
                        else desk[i, j] = 'X';
                    }
                }
            }

            desk[0, 0] = 'A';
            desk[1, 1] = 'B';

            for (int i=0; i<8; i++)
            {
                for (int j=0; j<8; j++)
                {
                    if (desk[i, j] == 'B')
                    {
                        int fi = i;
                        int fj = j;
                        // пешка
                        if ((desk[i - 1, j - 1] == 'A') || (desk[i - 1, j + 1] == 'A')) Console.WriteLine("p: YES");
                        else Console.WriteLine("p: NO");
                        // слон
                        if ((desk[i - 1, j - 1] == 'A') || (desk[i - 1, j + 1] == 'A')) Console.WriteLine("B: YES");
                        else Console.WriteLine("B: NO");
                        // ладья
                        if (desk[i,j]=='A') Console.WriteLine("R: YES");
                        else Console.WriteLine("R: NO");
                        // ферзь
                        if ((desk[i - 1, j - 1] == 'A') || desk[i - 1, j + 1] == 'A') Console.WriteLine("Q: YES");
                        else Console.WriteLine("Q: NO");
                        // конь
                        //if ((desk[i - 3, j - 1] == 'A') || (desk[i - 3, j + 1] == 'A')) Console.WriteLine("N: YES");
                        //else Console.WriteLine("N: NO");
                    }
                }
            }

            for (int i=0; i<8; i++)
            {
                for (int j=0; j<8; j++)
                {
                    Console.Write(desk[i, j]);
                }
                Console.WriteLine();
            }



        }
    }
}
