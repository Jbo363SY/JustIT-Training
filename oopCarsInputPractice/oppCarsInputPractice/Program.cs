using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopCarsPractice1
{
    class Car
 
    {

        public string name;
        public string model;
        public int price;
      

        public Car(string name, string model, int price)
        {
            this.name = name;
            this.model = model;
            this.price = price;

        } 

        public static void listCars(List<Car> allCars)
        //The list 'allCars' must be called in the method to allow it to grab the values in the list.
        {

            
            foreach (Car car in allCars)
            {
                Console.WriteLine("This is the car's name :" + " " + car.name);
                Console.WriteLine();
                Console.WriteLine("This is the car's model :" + " " + car.model);
                Console.WriteLine();
                Console.WriteLine("This is the car's price :" + " " +"£"+car.price);
                Console.WriteLine();

            }

        }

    }


    class Program
    {
        static void Main(string[] args)
        {

            


            List<Car> allCars = new List<Car>();
            string userInput;
            string userCarName;
            string userCarmodel;
            int userCarprice;



            do {
                Console.WriteLine("To add a car please type A or type X to exit");
                userInput = Console.ReadLine().ToUpper(); //userInput = Console.ReadLine().ToUpper; does not work if it is not initialised inside the loop.
                

                if (userInput == "A")

                {
                    Console.WriteLine("Please enter the car's make.");
                    userCarName = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("Please enter the car model.");
                    userCarmodel = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("Please enter the car price.");
                    userCarprice = Convert.ToInt32(Console.ReadLine());

                    Car newCar = new Car(userCarName, userCarmodel, userCarprice);
                    allCars.Add(newCar);

                    Console.WriteLine("Your car has been added");

                    Car.listCars(allCars);

                }
                else
                {
                    //Console.WriteLine("Please choose an option");

                }

                //Console.WriteLine("To add a car please type A or type X to exit");


            } while (userInput != "X");



        }
    }
}
