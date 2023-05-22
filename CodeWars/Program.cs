using System.Net.WebSockets;

namespace CodeWars
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Type second");

            int userInput = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine(formatDuration(userInput));


            string formatDuration(int seconds)
            {
                if (seconds == 0) return "now";
                var List=new List<string>();
                TimeSpan time = TimeSpan.FromSeconds(seconds);
                int year = time.Days / 365;
                int day = time.Days % 365;
                int hour= time.Hours;
                int minute= time.Minutes;
               int second= time.Seconds ;

                if(year > 0)

                { List.Add(year + " year " + (year > 1 ? "s" : "")); }
                if (day > 0)
                {
                    List.Add(day + " day " + (day > 1 ? "s" : ""));
                }
                if (hour > 0)
                {
                    List.Add(hour + " hour " + (hour > 1 ? "s" : ""));
                }
                if (minute > 0)
                {
                    List.Add(minute + " minute " + (minute > 1 ? "s" : ""));

                }
                if (second > 0)
                {
                    List.Add(second + " second " + (second > 1 ? "s" : ""));

                }

                var myArr = string.Join(", ",List.Take(List.Count()-1))+(List.Count()>1?"and":"")+List.Last();

                return myArr;
            }
        }
    }
}