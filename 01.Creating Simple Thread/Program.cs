using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CreatingSimpleThread
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread = new Thread(WriteY);  // Create new thread calls WriteY method.
            thread.Start();                      // Start the thread.

            WriteX();                            // Call WriteX method in the main thread.

            // Conclusion: the CPU switched between threads using its own technique 
            // to run them simultaneously.
        }

        static void WriteX()
        {
            for (int i = 0; i < 1000; i++) Console.Write("X");
        }

        static void WriteY()
        {
            for (int i = 0; i < 1000; i++) Console.Write("Y");
        }
    }
}
