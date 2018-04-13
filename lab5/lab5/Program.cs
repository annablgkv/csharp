using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----[ Задание #1 ] ----------------------------------------------------------------------");

            // Задание 1
            string str = "test";
            Console.WriteLine("Первый символ: {0}", str[0]);

            string str2 = new string('s', 5);
            char[] chararray = { 't', 'e', 's', 't' };
            string str3 = new string(chararray);

            Console.WriteLine("str= " + str + " str2= " + str2 + " str3= " + str3);

            // 3.   Протестируйте на созданных строках простейшие операции:
            str3 = "123";
            Console.WriteLine("str3= " + str3);
            Console.WriteLine("str3 == str2 - " + (str3 == str2) + "\nstr != str3 -  " + (str != str3) + "\nstr + str3 -  " + (str + str3));


            // 4.  Используя индексацию строк, выполните следующие задания:

            string str4 = "fjhj/* Это комментарий */";
            System.Text.StringBuilder temp = new System.Text.StringBuilder(100);
            int i = 0;
            int j = 0;

            while (i < str4.Length - 1)
            {
                if (str4[i] == '/' && str4[i + 1] == '*')
                {
                    i += 2;

                    while (!(str4[i] == '*' && str4[i + 1] == '/'))
                    {
                        temp.Insert(j, str4[i]);
                        Console.WriteLine("str4[i]= " + str4[i]);
                        i++;
                        j++;
                    }
                    break; //если ищется только один комментарий в строке
                }
                else
                {
                    i++;
                }

                string res = temp.ToString();
                Console.WriteLine(res);
            }

            // скопировать в новую строку все символы другой строки за исключением слова “student”;
            string str5 = "скопировать в новую строку все символы другой строки за исключением слова “student”;";
            if (str5.Contains("student")) str5 = str5.Replace("student", "");
            Console.WriteLine("str5= " + str5);

            Console.WriteLine("----[ end! Задание #1 ] -----------------------------------------------------------------\n\n");


            /* ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ */

            Console.WriteLine("----[ Задание #2 ] ----------------------------------------------------------------------");


            // Задание 2 

            Console.WriteLine("Введите число ");
            ulong digit = ulong.Parse(Console.ReadLine());
            Console.WriteLine(NumByWords.RurPhrase(digit));


            Console.WriteLine("----[ end! Задание #2 ] -----------------------------------------------------------------\n\n");


            /* ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ */

            Console.WriteLine("----[ Задание #3 ] ----------------------------------------------------------------------");


            // Задание 3 
            string str6 = "Как правило, строка delimiters состоит из одного символа, который и разделяет в результирующей строке элементы массива items; но в отдельных случаях ограничителем может быть строка из нескольких символов.";

            Console.WriteLine("\nИсходная строка:\n" + str6 + "\nПолученный массив :\n" + SplitJoin(str6));


            Console.WriteLine("----[ end! Задание #3 ] -----------------------------------------------------------------\n\n");


            /* ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ */

            Console.WriteLine("----[ Задание #4 ] ----------------------------------------------------------------------");

            // Задание 4 

            StringBuilder str7 = new StringBuilder("String – example of StringBuilder");
            StringBuilder str8 = new StringBuilder("String – example of StringBuilder2");
            Console.WriteLine("\n1 строка:\n" + str7 + "\n2 строка:\n" + str8);

            str7.Replace("String", "Text");
            Console.WriteLine("\n1 строка: Replace\n" + str7);
            str8.Append("dadwadawda");
            Console.WriteLine("\n2 строка: Append\n" + str8);
            str7.Insert(0, str8);
            Console.WriteLine("\n1 строка Insert:\n" + str7);
            str8.Remove(5, 5);
            Console.WriteLine("\n2 строка: Remove\n" + str8);


            string[] Words;
            // получим массив слов
            Words = str6.Split(' ');
            // очистим переменную
            str8.Remove(0, str8.Length);
            // соберем строку
            int num = 1;
            foreach (string word in Words)
            {
                str8.AppendFormat(" {0}: {1} ", num++, word);
            }
            Console.WriteLine("\n2 строка: AppendFormat\n" + str8);


            Console.WriteLine("----[ end! Задание #4 ] -----------------------------------------------------------------\n\n");

            /* ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ */

            Console.WriteLine("----[ Задание #5 ] ----------------------------------------------------------------------");


            // Задание 5

            Console.WriteLine("\n2 строка: Capacity = " + str8.Capacity);
            Console.WriteLine("\n2 строка: MaxCapacity = " + str8.MaxCapacity);
            str8.EnsureCapacity(580);
            Console.WriteLine("\n2 строка: Capacity = " + str8.Capacity);


            Console.WriteLine("----[ end! Задание #5 ] -----------------------------------------------------------------\n\n");


            /* ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ */

            Console.WriteLine("----[ Задание #6 ] ----------------------------------------------------------------------");


            // Задание 6

            // 6.2
            // char[] str10 = string.ToCharArray( "Hello, World!");
            string str11 = "Hello, World!";
            char[] str10 = str11.ToCharArray();
            string str9 = "Здравствуй, Мир!";
            // 6.3
            //Console.WriteLine("\nchar[]: " + str10);
            PrintCharAr(str10);
            PrintCharAr(str9.ToCharArray());

            // 6.4
            string str12 = CharArrayToString(str10);
            Console.WriteLine("\nstr12 строка: " + str12);

            // 6.5
            char[] str13 = new char[1];
            str13[0] = 'l';
            Console.WriteLine("\nIndexOfStr " + IndexOfStr(str10, str13));

            // 6.6
            TestIndexSym();
            /* ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ */


            Console.ReadLine();

            Console.WriteLine("----[ end! Задание #6 ] -----------------------------------------------------------------\n\n");

        }

        // Задание 2. 

        public class NumByWords
        {
            public static string RurPhrase(decimal money)
            {
                return CurPhrase(money, "рубль", "рубля", "рублей"); //, "копейка", "копейки", "копеек");
            }
            //public static string UsdPhrase(decimal money)
            //{
            //    return CurPhrase(money, "доллар США", "доллара США", "долларов США", "цент", "цента", "центов");
            //}

            public static string NumPhrase(ulong Value, bool IsMale)
            {
                if (Value == 0UL) return "Ноль";
                string[] Dek1 = { "", " од", " дв", " три", " четыре", " пять", " шесть", " семь", " восемь", " девять", " десять", " одиннадцать", " двенадцать", " тринадцать", " четырнадцать", " пятнадцать", " шестнадцать", " семнадцать", " восемнадцать", " девятнадцать" };
                string[] Dek2 = { "", "", " двадцать", " тридцать", " сорок", " пятьдесят", " шестьдесят", " семьдесят", " восемьдесят", " девяносто" };
                string[] Dek3 = { "", " сто", " двести", " триста", " четыреста", " пятьсот", " шестьсот", " семьсот", " восемьсот", " девятьсот" };
                string[] Th = { "", "", " тысяч", " миллион", " миллиард", " триллион", " квадрилион", " квинтилион" };
                string str = "";
                for (byte th = 1; Value > 0; th++)
                {
                    ushort gr = (ushort)(Value % 1000);
                    Value = (Value - gr) / 1000;
                    if (gr > 0)
                    {
                        byte d3 = (byte)((gr - gr % 100) / 100);
                        byte d1 = (byte)(gr % 10);
                        byte d2 = (byte)((gr - d3 * 100 - d1) / 10);
                        if (d2 == 1) d1 += (byte)10;
                        bool ismale = (th > 2) || ((th == 1) && IsMale);
                        str = Dek3[d3] + Dek2[d2] + Dek1[d1] + EndDek1(d1, ismale) + Th[th] + EndTh(th, d1) + str;
                    };
                };
                str = str.Substring(1, 1).ToUpper() + str.Substring(2);
                return str;
            }

            #region Private members
            private static string CurPhrase(decimal money, string word1, string word234, string wordmore) //, string sword1, string sword234, string swordmore)
            {
                money = decimal.Round(money, 2);
                decimal decintpart = decimal.Truncate(money);
                ulong intpart = decimal.ToUInt64(decintpart);
                // перевод цифр в текст
                string str = NumPhrase(intpart, true) + " ";
                // вычисление целой части (руб)
                byte endpart = (byte)(intpart % 100UL);
                if (endpart > 19) endpart = (byte)(endpart % 10);
                switch (endpart)
                {
                    case 1: str += word1; break;
                    case 2:
                    case 3:
                    case 4: str += word234; break;
                    default: str += wordmore; break;
                }
                // вычисление десятой части (копейки)
                //byte fracpart = decimal.ToByte((money - decintpart) * 100M);
                //str += " " + ((fracpart < 10) ? "0" : "") + fracpart.ToString() + " ";
                //if (fracpart > 19) fracpart = (byte)(fracpart % 10);
                //switch (fracpart)
                //{
                //    case 1: str += sword1; break;
                //    case 2:
                //    case 3:
                //    case 4: str += sword234; break;
                //    default: str += swordmore; break;
                //};
                return str;
            }
            private static string EndTh(byte ThNum, byte Dek)
            {
                bool In234 = ((Dek >= 2) && (Dek <= 4));
                bool More4 = ((Dek > 4) || (Dek == 0));
                if (((ThNum > 2) && In234) || ((ThNum == 2) && (Dek == 1))) return "а";
                else if ((ThNum > 2) && More4) return "ов";
                else if ((ThNum == 2) && In234) return "и";
                else return "";
            }
            private static string EndDek1(byte Dek, bool IsMale)
            {
                if ((Dek > 2) || (Dek == 0)) return "";
                else if (Dek == 1)
                {
                    if (IsMale) return "ин";
                    else return "на";
                }
                else
                {
                    if (IsMale) return "а";
                    else return "е";
                }
            }
            #endregion
        }

        // Задание 3 

        public static string SplitJoin(string str)
        {
            string[] SimpleSentences, Words;

            SimpleSentences = str.Split(',');
            Words = str.Split(' ');

            // проверка
            Console.WriteLine("Полученный массив слов: \n");
            foreach (string word in Words)
            {
                Console.WriteLine(word);
            }
            Console.WriteLine("\n \n");
            // ---------

            str = string.Join(" ", Words);

            return str;
        }

        // Задание 6
        // 6.3
        public static void PrintCharAr(char[] str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                Console.Write(str[i]);
            }
        }
        // 6.4
        public static String CharArrayToString(char[] array)
        {
            string result = "";
            for (int i = 0; i < array.Length; i++) result += array[i];
            return (result);
        }
        // 6.5
        public static int IndexOfStr(char[] s1, char[] s2)
        {
            //возвращает индекс первого вхождения подстроки s2 в 
            //строку s1
            int i = 0, j = 0, n = s1.Length - s2.Length; bool found = false;
            while ((i <= n) && !found)
            {
                j = Array.IndexOf(s1, s2[0], i);
                if (j <= n)
                {
                    found = true; int k = 0;
                    while ((k < s2.Length) && found)
                    {
                        found = char.Equals(s1[k + j], s2[k]); k++;
                    }
                }
                i = j + 1;
            }
            if (found) return (j); else return (-1);
        }
        // 6.6
        public static void TestIndexSym()
        {
            char[] str1, str2;
            str1 = "рококо".ToCharArray();
            //определение вхождения символа	
            int find, lind;
            find = Array.IndexOf(str1, 'о');
            lind = Array.LastIndexOf(str1, 'о');
            Console.WriteLine("Индексы вхождения о в рококо:{0},{1};", find, lind);
            //определение вхождения подстроки
            str2 = "рок".ToCharArray();
            find = IndexOfStr(str1, str2);
            Console.WriteLine("Индекс первого вхождения рок в рококо:{0}", find);

            str2 = "око".ToCharArray();
            find = IndexOfStr(str1, str2);
            Console.WriteLine("Индекс первого вхождения око в рококо:{0}", find);
        }

    }
}
