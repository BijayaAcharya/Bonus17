using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus17
{
    class UsedCar : Car
    {

        private double mileage; // field

        public double Mileage // properties
        {
            set { mileage = value; }
            get { return mileage; }
        }

        public UsedCar(string m, string mo, int yr, double pr, double ml) : base(m, mo, yr, pr) // inheritance
        {
            Mileage = ml;
        }

             
       

        public override void PrintInfo()
        {
            base.PrintInfo(); // calls code from the top
            Console.WriteLine($"Mileage {Mileage}");
           
        }
    }
}
