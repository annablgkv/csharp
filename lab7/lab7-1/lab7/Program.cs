using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    class Person
    {
        private string fam    = "";
        private string status = "default";
        private double salary = 0;
        private int age       = 0;
        private string health = "default";

        // стратегия: Read,Write-once (Чтение, запись при первом обращении) 
        public string Fam
        {
            set { if (fam == "") fam = value; }
            get { return (fam); }
        }

        // стратегия: чтение, запись (Read, Write)
        public int Age
        {
            set { age = value; }
            get { return (age); }
        }

        // стратегия: только чтение (Read-only)
        public string Status
        {
            get { return (status); }
        }

        // стратегия: только запись (Write-only);
        public int Salary
        {
            set { salary = value; }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            // задание #7-1
            Person user = new Person();
            user.Fam = "Kokol";
            user.Age = 45;
            //user.Status = "Adult"; - нельзя
            user.Salary = 65;

            //Console.WriteLine("Фамилия: {0}\n Статус: {1}\n Зарплата: {2}\n Возраст: {3}\n Здоровье: {4}", user.Fam, user.Status, user.Salary, user.Age, user.health);
            Console.WriteLine("Фамилия: {0}\n Статус: {1}\n Зарплата: нельзя\n Возраст: {2}\n Здоровье: нет метода", user.Fam, user.Status, user.Age);



        }
    }
}
