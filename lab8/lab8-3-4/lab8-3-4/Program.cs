using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;
using System.Runtime.InteropServices;



namespace lab8_3_4
{
    class BaseClass : IDisposable
    {
        private int val;

        public BaseClass(int temp) {
            val = temp;
            Console.WriteLine("{0}", temp);
        }

        public void Show()
        {
            Console.WriteLine("{0}", val);
        }

        // Flag: Has Dispose already been called?
        bool disposed = false;
        // Instantiate a SafeHandle instance.
        SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);

        // Public implementation of Dispose pattern callable by consumers.
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        // Protected implementation of Dispose pattern.
        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                handle.Dispose();
                // Free any other managed objects here.
                //
            }

            // Free any unmanaged objects here.
            //
            disposed = true;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BaseClass temp = new BaseClass(495);

            temp.Dispose();

            temp.Show();
            
        }
    }
}
