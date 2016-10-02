using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class LinkedListPerfomance
    {
        public static LinkedList<int> TestLinkedList { get; set; } = new LinkedList<int>();

        public static TimeSpan AddingTime()
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            for (int i = 0; i < 1000000; i++)
            {
                TestLinkedList.AddLast(i);
            }
            stopWatch.Stop();
            return stopWatch.Elapsed;
        }

        public static string ReadingTime()
        {
            Stopwatch stopWatch = new Stopwatch();
            int y;
            stopWatch.Start();
            foreach (int i in TestLinkedList)
            {
                y = i;
            }
            stopWatch.Stop();
            TimeSpan timeSpan = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:0000}",
                timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds, timeSpan.Milliseconds);
            return elapsedTime;
        }

        public static string SearchTime()
        {
            Stopwatch stopWatch = new Stopwatch();
            int y;
            stopWatch.Start();
            foreach (int i in TestLinkedList)
            {
                if (i == 12345)
                {
                    y = i;
                }
            }
            stopWatch.Stop();
            TimeSpan timeSpan = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:0000}",
                timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds, timeSpan.Milliseconds);
            return elapsedTime;
        }

        public static string RemovingTime()
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            for (int i = 0; i < 100000; i++)
            {
                TestLinkedList.Remove(i);
            }
            stopWatch.Stop();
            TimeSpan timeSpan = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00000}",
                timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds, timeSpan.Milliseconds);
            return elapsedTime;
        }
    }
}

