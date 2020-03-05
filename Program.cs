using System;
using System.Threading.Tasks;
using System.Diagnostics;

namespace TaskCase
{
    class Program
    {
        //public static long StartTime;

        static async Task Main(string[] args)
        {
            await Run(5000);
        }

        public static async Task Run(int offset)
        {
            Console.WriteLine("Start Function");
            Stopwatch watch = new Stopwatch();            
            watch.Start();
            //StartTime = watch.ElapsedMilliseconds;

            await Task.Run(()=> {
                //int ctr = 0;
                //for (ctr = 0; ctr <= 100000;ctr++)
                //{}
                //Console.WriteLine("Finished {0} LoaderOptimization iterations", ctr);
                while (true)
                {
                    long elapsedtime = watch.ElapsedMilliseconds;
                    Console.WriteLine("ElapsedMilliseconds {0}", elapsedtime);

                    if (elapsedtime > offset)
                    break;
                }                
            });
            Console.WriteLine("End Function");
        }
    }
}
