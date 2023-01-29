using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    class Car
    {
        
        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;

        public Car()
        {

        }
        public Car(string make,string model,int year):this()
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }
        public Car(string make,string model,int year,double fuelQuantity,double fuelConsumption):this()
        {
            this. FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }
        public string Make { get; set; }
        public string Model { get; set; }

        public int Year { get; set; }
        public double FuelQuantity { get; set; }
         public double FuelConsumption { get; set; }

        public void Drive (double distance)
        {

            if (this.FuelQuantity - distance *this.fuelConsumption >0)
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
            else
            {
                FuelQuantity -= distance*this.fuelConsumption;
            }
        }
        public void WhoIAm()
        {
            StringBuilder sb = new StringBuilder();
           sb.AppendLine($"Make: {this.Make}");
            sb.AppendLine($"Model: {this.Model}");
            sb.AppendLine($"Year: {this.Year}");
            sb.AppendLine($"Fuel: {this.FuelQuantity:F2}");
            Console.WriteLine(sb);
        }

    }
}
