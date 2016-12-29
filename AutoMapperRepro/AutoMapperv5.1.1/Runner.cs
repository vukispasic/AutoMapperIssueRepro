using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapperv5
{
    class Runner
    {
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            var automapperv5 = new Reprov5();
            automapperv5.Run();
            stopwatch.Stop();
            Console.WriteLine("End");
            Console.ReadLine();
        }
    }
}
