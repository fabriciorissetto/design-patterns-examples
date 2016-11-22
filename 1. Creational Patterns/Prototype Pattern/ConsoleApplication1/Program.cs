using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            var watch = Stopwatch.StartNew();
            for (int i = 0; i < 100; i++)
            {
                var asteroid = new Asteroid();
            }
            watch.Stop();
            Console.WriteLine("Time to instantiate 100 asteroids: " + watch.ElapsedMilliseconds);


            watch = Stopwatch.StartNew();
            var asteroidTemplate = new Asteroid();
            for (int i = 0; i < 100; i++)
            {
                var asteroid = asteroidTemplate.Clone();
            }
            watch.Stop();
            Console.WriteLine("Time to copy 100 asteroids: " + watch.ElapsedMilliseconds);

            Console.ReadKey();
        }
    }
}
