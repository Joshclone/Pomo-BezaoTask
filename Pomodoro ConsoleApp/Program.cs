using System;
using System.Diagnostics;
using System.Timers;


namespace Pomodoro_ConsoleApp
{
    internal class Program
    {
       

        static void Main(string[] args)
        {

            while (true)
            {
                
                Console.WriteLine("Please enter your prefered work time: ");
                int workTime = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Saved");

    //here user enters their prefered work time and rest time
                Console.WriteLine("\nPlease input your prefered restperiod: ");
                int restPeriod = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Rest Period saved please proceed");



            AppTimer timer = new AppTimer(workTime, restPeriod);
                //Prompts the user to start timer
                Console.WriteLine("\nDo you want to start the timer(y/n): ");

                string? startTimer = Console.ReadLine();


                if(startTimer == "y")
                {
                    Console.WriteLine("\nWork timer is running...");
                    timer.startWorkTime();

                    Console.WriteLine("\nRest timer is running...");
                    timer.startRestPeriod();
                }

                else if(startTimer == "n")
                {
                    continue;
                }

                else if(startTimer != "n" && startTimer != "y")
               {
                    Console.WriteLine("\nPlease enter a valid input, y for yes and n for no");
                    continue;
                }


                
                Console.WriteLine("\nWould you like to keep using the timer(y/n): ");

                string? continueUsingTimer = Console.ReadLine();

                if(continueUsingTimer == "y")
                {
                    continue;
                }
                else if(continueUsingTimer == "n")
                {
                    break;
                }
                else if (continueUsingTimer != "n" && continueUsingTimer != "y")
                {
                    Console.WriteLine("\nPlease enter a valid input next time, y for yes and n for no");
                    break;
                }

            }
        }
    }
}
