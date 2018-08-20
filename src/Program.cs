using System;
using System.Threading;
using System.Threading.Tasks;

namespace SigTermTest
{
    class Program
    {
        static async Task<int> Main(string[] args)
        {
            var cts = new CancellationTokenSource();

            AppDomain.CurrentDomain.ProcessExit += (s, e) => 
            {
                Console.WriteLine("ProcessExit!");
                cts.Cancel();
            };

            Console.WriteLine("Waiting for SIGTERM...");

            await Task.Delay(-1, cts.Token);

            Console.WriteLine("Exiting...");

            return 0;
        }
    }
}
