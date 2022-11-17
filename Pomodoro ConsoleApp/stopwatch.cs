using System;
using System.Timers;
using System.Diagnostics;
using System.Threading;

namespace Pomodoro_timer
{
    public class AppTimer
    {

        Stopwatch stopwatch = new Stopwatch();

        private int workTime;
        private int restPeriod;


     

        public AppTimer(int workTime, int restPeriod)
        {
            this.workTime = workTime;
            this.restTime = restPeriod;
        }


        public void startWorkTime()
        {
            Stopwatch stopWatch = new Stopwatch();

            stopWatch.Start();
            var workTimeStart = DateTime.Now.ToString("HH:mm");


            Thread.Sleep(this.workTime);


            stopWatch.Stop();
            var workTimeEnd = DateTime.Now.ToString("HH:mm"); 


            TimeSpan ts = stopWatch.Elapsed;

            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);


            Console.WriteLine($"\nWork time lasted for {elapsedTime} \n{workTimeStart} - {workTimeEnd}");
        }



        public void startRestPeriod()
        {
            Stopwatch stopWatch = new Stopwatch();

            stopWatch.Start();
            var restPeriodBegins = DateTime.Now.ToString("HH:mm");


            Thread.Sleep(this.restPeriod);


            stopWatch.Stop();
            var restPeriodEnd = DateTime.Now.ToString("HH:mm");


            TimeSpan ts = stopWatch.Elapsed;

            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);


            Console.WriteLine($"\nRestPeriod lasted for {elapsedTime} \n{restPeriodBegins} - {restPeriodEnd}");
        }


    }
}