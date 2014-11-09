using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleApplication1
{
   
    class Program
    {
        
        static void Main(string[] args)
        {
            //Stopwatch stopwatch = Stopwatch.StartNew(); //creates and start the instance of Stopwatch

            Point l1 = new Point(100, 100);
            Point l2 = new Point(100, 1600);
            Point r1 = new Point(1600, 100);
            Point r2 = new Point(1600, 1600);

            Point origin = new Point(800,600);
            Point collisionPoint = new Point(100,903);
            Solver solver = new Solver();
            Point result = solver.getOrigin(l1, l2, r1, r2, origin, collisionPoint);

            Console.WriteLine("result is : x:"+ result.x + " y:" + result.y);
            //stopwatch.Stop();
            //Console.WriteLine(stopwatch.ElapsedMilliseconds);
            while(true);
            
        }

    }
}
