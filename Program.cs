using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus17
{
    class Program
    {
        static void Main(string[] args)
        {
            
                           
                
                Car newcar1 = new Car("Chevy", "Impala", 2017, 4000);
                Car newcar2 = new Car("Jeep", "Compass", 2014, 5000);
                Car newcar3 = new Car("Madza", "Cx5", 2017, 9000);


                UsedCar usedCar1 = new UsedCar("ford", "Escape", 2016, 7000, 23840);
                UsedCar usedCar2 = new UsedCar("Toyota", "Highlander", 2018, 10000, 40100);
                UsedCar usedCar3 = new UsedCar("Nissan", "Altima", 2010, 8000, 57768);

                              

                List<Car> carList = new List<Car>() { newcar1, newcar2, newcar3, usedCar1, usedCar2, usedCar3 };

               
                foreach (Car singleCar in carList)
                {

                    singleCar.PrintInfo();
                }

               Console.WriteLine(" Which car would you like? Enter a number between 0-5");
              int choice = int.Parse(Console.ReadLine());

               carList[choice].PrintInfo();
            
            

              Console.WriteLine(" Would you like to buy a car? y/n");
              string select = Console.ReadLine().ToLower();
            

            while (true)
            {
                            
                if (select == "y")
                {
                    Console.WriteLine(" Excellent! Our finance department will be in touch shortly.");
                }
                else
                {
                    Console.WriteLine(" Have a great day!");
                }
                Console.ReadLine();
                
                
                
                
            }
             
        }
    }
}


    
   
              