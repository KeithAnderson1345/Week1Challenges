using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_1_Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Keith";
            string lastName = "Anderson";
            int age = 48;

            string[] favMovies = { "Fletch", "Christmas Vacation", "Dazed And Confused", "A Christmas Story" };

            Console.WriteLine(favMovies[0]);
            Console.WriteLine(favMovies[1]);
            Console.WriteLine(favMovies[2]);
            Console.WriteLine(favMovies[3]);

            List<DateTime> dateTimes = new List<DateTime>();
            DateTime currentDateTime = DateTime.Now;
            DateTime birthday = new DateTime(1972, 06, 13);
            DateTime momBD = new DateTime(1948, 04, 05);
            DateTime dadBD = new DateTime(1947, 09, 09);
            dateTimes.Add(currentDateTime);
            dateTimes.Add(momBD);
            dateTimes.Add(dadBD);
            dateTimes.Add(birthday);

            Console.WriteLine(dateTimes[0]);
            Console.WriteLine(dateTimes[1]);
            Console.WriteLine(dateTimes[2]);
            Console.WriteLine(dateTimes[3]);

            int addAge = age + 7;
            int diffAge = age - 7;
            int prodAge = age * 7;
            int quotAge = age / 7;
            int remAge = age % 7;
            Console.WriteLine(addAge);
            Console.WriteLine(diffAge);
            Console.WriteLine(prodAge);
            Console.WriteLine(quotAge);
            Console.WriteLine(remAge);


            int sleepTime = 5;
            
            if (sleepTime >= 10)
            {
                Console.WriteLine("Wow that's a lot of sleep!");
            }
            else if (sleepTime > 8)
            {
                Console.WriteLine("You should be pretty rested");
            }
            else if (sleepTime > 4)
            {
                Console.WriteLine("Bummer");
            }
            else
            {
                Console.WriteLine("Oh man, get some sleep!");
            }

            string userDay = "Horrible";
            switch (userDay)
            {
                case "Great":
                    Console.WriteLine("Awesome!");
                    break;
                case "Good":
                    Console.WriteLine("Better than Okay");
                    break;
                case "Okay":
                    Console.WriteLine("Better than Bad");
                    break;
                case "Bad":
                    Console.WriteLine("Sorry to hear that. Hope it gets better.");
                    break;
                case ":(":
                    Console.WriteLine("Anything I can do to help make it better?");
                    break;
                default:
                    Console.WriteLine("Go back to bed");
                    break;
            }

            Console.ReadLine();
        }
    }
}
