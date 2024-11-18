using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackThread
{
    internal class MyThreadClass
    {
        public static void Thread1() {
            Thread thread = Thread.CurrentThread;
            for (int i = 0; i <=2; i++) {
                Debug.WriteLine("Name of Thread: " + thread.Name+" = "+ i);

                Thread.Sleep(500);
            }
        }
        public static void Thread2()
        {
            Thread thread = Thread.CurrentThread;
            for (int i = 0; i <= 5; i++)
            {
                Debug.WriteLine("Name of Thread: " + thread.Name + " = " + i);
                Thread.Sleep(1500);
            }
        }
    }
}
