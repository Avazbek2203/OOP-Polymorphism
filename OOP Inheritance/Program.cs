using System;

namespace OOP_Inheritance
{
    internal class Program
    {
        private static void Main(string[] args)
        {
          
            TeslaZ teslaZ = new TeslaZ("Model Z", 100000m, 75.5, 3, 42);
           
            teslaZ.Drive();

            teslaZ.Stop();
 
            Console.WriteLine($"Tesla Z version: {teslaZ.TeslaVersion}");
            Console.WriteLine($"Tesla Z number: {teslaZ.ZNumber}");
 
            TeslaX teslaX = new TeslaX("Model X", 150000m, 100.0, 4, 21);
   
            teslaX.Drive();
  
            Console.WriteLine($"Tesla X version: {teslaX.TeslaVersion}");
            Console.WriteLine($"Tesla X number: {teslaX.XNumber}");

            Car[] cars = new Car[2];
            cars[0] = new TeslaZ("Model Z", 100000m, 75.5, 3, 42);
            cars[1] = new TeslaX("Model X", 150000m, 100.0, 4, 21);

            foreach (Car car in cars)
            {
                car.Drive();
            }
        }
    }
}
