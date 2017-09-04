using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using PiMarkCore;
namespace PiMarkConsole
{
    class Program
    {
        private static void PrintHelp()
        {
            Console.WriteLine("usage: -t <sum of thread (bigger than 0) > -c <cycles of calculation (bigger than 99)>");
        }
        

        private static ManualResetEvent reset = new ManualResetEvent(false);

        private static UInt64 start = 0;

        private static List<Thread> threads = new List<Thread>();

        private static int allFinishedCounts = 0;

        private static uint threadCount = 0;
        private static uint cycleCount = 0;
        private static int cycleFinishedCounts = 0;

        private static void AllFinished()
        {
            allFinishedCounts++;
            if (allFinishedCounts >= threads.Count)
            {
                UInt64 end = UInt64.Parse(DateTime.Now.ToFileTimeUtc().ToString());

                string result = ((int)((1.0 / ((end - start) / 345)) * 100000000 * ((double)cycleCount / 100.0))).ToString();
                Console.WriteLine("result: " + result);
                Console.WriteLine("baseline: 1000 on a Intel i5 2310 @ 3.1GHz with single thread");
                threads.Clear();
            }
            reset.Set();
        }

        private static void Once()
        {
            cycleFinishedCounts++;
            try
            {
                int l = Console.CursorLeft;
                int t = Console.CursorTop;
                Console.Write($"{cycleFinishedCounts / (float)cycleCount * 100f}%");
                Console.SetCursorPosition(l, t);
            }
            catch(Exception ex)
            {
                string output = $"{cycleFinishedCounts / (float)cycleCount * 100f}%";
                Console.Write(output);
                for(int i = 0; i< output.Length;i++)
                {
                    Console.Write("\b");
                }
            }
            return;
        }

        static void Main(string[] args)
        {
            if (args.Length != 4)
            {
                PrintHelp();
                return;
            }

            try
            {
                for (int i = 0; i < args.Length; i++)
                {
                    if (args[i].Contains("t"))
                    {
                        threadCount = uint.Parse(args[i + 1]);
                    }
                    else if (args[i].Contains("c"))
                    {
                        cycleCount = uint.Parse(args[i + 1]);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid arguments");
                PrintHelp();
                return;
            }

            if (threadCount < 1 || cycleCount < 100)
            {
                PrintHelp();
                return;
            }

            for (int i = 0; i < threadCount; i++)
            {
                PiCalculator calculator = null;
                if (i == threadCount - 1)
                {
                    calculator = new PiCalculator((uint)(cycleCount / threadCount + (cycleCount % threadCount)), Once, AllFinished);
                }
                else
                {
                    calculator = new PiCalculator((uint)(cycleCount / threadCount), Once, AllFinished);
                }
                threads.Add(new Thread(new ThreadStart(calculator.run)));
            }

            Console.WriteLine($"start {cycleCount} calculation(s) on {threadCount} thread(s)");
            start = UInt64.Parse(DateTime.Now.ToFileTimeUtc().ToString());
            foreach (var t in threads)
            {
                t.Start();
            }
            reset.WaitOne();
        }
    }
}
