using Properties;

namespace Classwork2OOPS
{
    internal class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("Enter the seconds :");
            int seconds = Convert.ToInt32(Console.ReadLine());
            TimePeriod timePeriod = new TimePeriod(seconds);
            Console.WriteLine("Time in hours:" + timePeriod.Hours);
            Console.WriteLine("Enter the Hour :");
            timePeriod.Hours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Time in seconds: " + timePeriod.Hours * 3600);



        }
    }
}
