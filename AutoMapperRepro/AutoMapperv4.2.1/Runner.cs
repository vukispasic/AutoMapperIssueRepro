using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapperv4
{
    class Runner
    {
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            var automapperv4 = new Reprov4();
            automapperv4.Run();
            stopwatch.Stop();
            Console.WriteLine("End");
            Console.ReadLine();
        }
    }
}
