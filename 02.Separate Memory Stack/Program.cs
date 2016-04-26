using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _02.Separate_Memory_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread = new Thread(DoWork);   // Create new thread calls DoWork method.
            thread.Start();                       // Start the thread.

            DoWork();                             // Call DoWork method in the main thread.

            // Conclusion: "Doing Work!" is printed 10 times not 5 which means
            // that each thread has it own separate memory stack for its locals.
        }

        static void DoWork()
        {
            for (int i = 0; i < 5; i++)
                Console.WriteLine("Doing Work!");
        }
    }
}
