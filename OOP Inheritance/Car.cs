using System;

namespace OOP_Inheritance
{
    internal abstract class Car
    {
        public string Model { get; set; }
        public decimal Price { get; set; }

        public Car(string model, decimal price)
        {
            Model = model;
            Price = price;
        }

        public abstract void Drive();
    }

    internal class ExpensiveCar : Car
    {
        public virtual double Battery { get; set; }

        public ExpensiveCar(string model, decimal price, double battery)
            : base(model, price)
        {
            Battery = battery;
        }

        public override void Drive()
        {
            Console.WriteLine($"Driving the {Model} expensive car.");
        }

        public virtual void Stop()
        {
            Console.WriteLine($"Expensive car {Model} is stopping");
        }
    }
    

    internal class Tesla : ExpensiveCar
    {
        public int TeslaVersion { get; set; }

        public Tesla(string model, decimal price, double battery, int teslaVersion)
            : base(model, price, battery)
        {
            TeslaVersion = teslaVersion;
        }

        public override void Drive()
        {
            Console.WriteLine($"Driving the {Model} Tesla car.");
        }
    }

    internal class TeslaZ : Tesla
    {
        public virtual int ZNumber { get; set; }

        public TeslaZ(string model,
            decimal price,
            double battery,
            int version,
            int number)
            : base(model, price, battery, version)
        {
            ZNumber = number;
        }

        public override void Drive()
        {
            Console.WriteLine($"Driving the {Model} Tesla Z car.");
        }
    }

    internal class TeslaX : Tesla
    {
        public virtual int XNumber { get; set; }

        public TeslaX(string model,
            decimal price,
            double battery,
            int version,
            int number)
            : base(model, price, battery, version)
        {
            XNumber = number;
        }

        public override void Drive()
        {
            Console.WriteLine($"Driving the {Model} Tesla X car.");
        }
    }
}
