using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab8_2_3
{
    public partial class Form1 : Form
    {
        private Timer t;
        private myClass temp;

        public Form1()
        {
            InitializeComponent();
        }

        void t_Tick(object sender, EventArgs e)
        {
            //progressBar1.Value += 10;
            if (progressBar1.Value >= 100) t.Stop();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            t = new Timer();
            t.Interval = 1000;
            t.Tick += new EventHandler(t_Tick);
            t.Start();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            progressBar1.Value += 10;
            if (progressBar1.Value >= 100) t.Stop();
            temp = new myClass(1998, "anna");

        }
    }

    public class myClass : EventArgs
    {
        private int num;
        private string str;

        public myClass(int a, string b)
        {
            num = a;
            str = b;
        }

        public delegate void MyEvent(object myClass, EventArgs e);

        public event MyEvent MagicEvent;

        // Wrap the event in a protected virtual method
        // to enable derived classes to raise the event.
        protected virtual void OnRaiseSampleEvent()
        {
            // Raise the event by using the () operator.
            MagicEvent?.Invoke(this, new myClass(1996, "misha"));
        }


    }
}
