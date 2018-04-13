using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8_3_1
{

    class Todo
    {
        private List<int> todos = new List<int>();
        //private int[] todos;

        /////////////////////////////////////////////////////
        public Todo()
        {
            Console.WriteLine("*Todo");
        }
        /////////////////////////////////////////////////////
        public void AddTodo(int a)
        {
            todos.Add(a);
        }
        /////////////////////////////////////////////////////
        public void Show()
        {
            foreach (int todo in todos)
            {
                Console.WriteLine(todo);
            }
        }
        /////////////////////////////////////////////////////

    }

    class Program
    {
        static void Main(string[] args)
        {

            Todo temp = new Todo();

            temp.AddTodo(200);
            temp.AddTodo(5000);
            temp.AddTodo(30);

            temp.Show();

        }
    }
}
