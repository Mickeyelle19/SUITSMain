using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SACSUITSMain
{
    public class NavigationProgram
    {
        public NavigationProgram()
        {
            //Test
            //Class constructor, leave empty
        }
        static void stopWatch()
        {
            bool start = true;
            Stopwatch watch = new Stopwatch();
            watch.Start();

            while (start == true)
            {
                Thread.Sleep(1000);
                TimeSpan ts = watch.Elapsed;
                string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                 ts.Hours, ts.Minutes, ts.Seconds,
                 ts.Milliseconds / 10);
                Console.WriteLine("Time elapsed: " + elapsedTime);
            }
            Console.ReadLine();
            watch.Stop();
            start = false;
        }

        //Rest of the code for this class goes 
        //below, all methods, variables, 
        //functions, etc.
    }
}
