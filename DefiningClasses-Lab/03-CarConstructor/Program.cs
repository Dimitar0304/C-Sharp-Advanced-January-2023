using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string make = Console.ReadLine();
            string model = Console.ReadLine();
            int year = int.Parse(Console.ReadLine());
            double fuelQuantity = double.Parse( Console.ReadLine());
            double fuelConsumption = double.Parse(Console.ReadLine());

            Car car1 = new Car();
            Car car2 = new Car(make, model, year);
            Car ca3 = new Car(make, model, year, fuelQuantity, fuelConsumption);

            Console.WriteLine();

        }
    }
}
