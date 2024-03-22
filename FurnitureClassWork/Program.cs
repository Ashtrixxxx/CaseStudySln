using FurnitureClassWork.Model;

namespace FurnitureClassWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Furniture f = new Furniture();
            Console.WriteLine("Enter the Furniture Details To calculate cost");
            f.Name = Console.ReadLine();
            f.Material = Console.ReadLine();
            f.Price = Convert.ToInt32(Console.ReadLine());
            f.Numberofshelves = Convert.ToInt32(Console.ReadLine()); ;

            Chair chair = new Chair();
            chair.Name = Console.ReadLine();
            chair.Material = Console.ReadLine();
            chair.Price = Convert.ToInt32(Console.ReadLine()); ;
            chair.IsAdjustable = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine($"Cost of the bookShelf is {f.CalculateCost()}");
            Console.WriteLine($"Cost of the chair is {chair.CalculateCost()}");
        }
    }
}
