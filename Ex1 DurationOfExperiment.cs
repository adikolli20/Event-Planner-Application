
using  System;
namespace Ex1_Duration_of_experiment
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the total nr in seconds");
            int total = Convert.ToInt32(Console.ReadLine());
            int seconds = total % 60;
            int hours = total / 3600;
            int minutes = (total - hours * 3600) / 60;
            string output = "The duration of experiment was : ";
            if (hours!=0)
            {
                output += hours + " hours ";

            }
            if (minutes!=0)
            {
                output += minutes + " minutes ";
            }
            if (seconds!=0)
            {
                output += seconds + " seconds";
            }
            Console.Out.WriteLine(output);
        }
    }
}