using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopVehicleInheritancePractice
{

    class Vehicle
    {
        public string name;
        public string model;
        public string type;
        public int price;
        public bool sold;

        public static int totalValueSold = 0;
        public static int totalValueStock = 0;

        public Vehicle(string name, string model, int price, string type)
        {

            this.type = type;
            this.model = model;
            this.name = name;
            this.price = price;
            

            totalValueStock += price;

        }

        public void listOneVehicle()

        {
            Console.WriteLine("Here are the attributes of the " +" "+ type);

            Console.WriteLine("name :{0}, model: {1} & price: £{2:N0}", name, model, price);

            if (sold)
            {
                Console.WriteLine("This Vehicle has been sold");

            }
            else
            {
                Console.WriteLine("This vehicle is still available.");

            }
            Console.WriteLine();
        }

        public void SoldOneVehicle(bool isSold, int price)
        {
            this.sold = isSold;
            this.price = price;
            if (isSold)
            {
                Vehicle.totalValueSold += price;
                Vehicle.totalValueStock -= price;
            }
        }

        public static void DisplayAllVehicles(List<Vehicle> allVehicles)
        {
            foreach (Vehicle vehicle in allVehicles)
            {
                Console.WriteLine("The details of this {0} are: ", vehicle.type);
                Console.Write("Make and model: {0} {1}, price: £{2:N0}.", vehicle.name, vehicle.model, vehicle.price);  //:N0 formats the number
                if (vehicle.sold)
                {
                    Console.WriteLine("This {0} has been sold.", vehicle.type);

                }
                else
                {
                    Console.WriteLine("This {0} is still available.", vehicle.type);

                }
            }

            Console.WriteLine();
            Console.WriteLine("The total value of vehicles sold is: £{0:N0}.", totalValueSold);
            Console.WriteLine("The total value of vehicles in stock is: £{0:N0}.", totalValueStock);

            Console.WriteLine();
        }

    }

    class Car : Vehicle
    {
        public static int numOfCars;

        public Car(string name, string model, int price, string type = "car"): base(name, model, price, type)

        // public Car(string type = "car", string name, string model, int price): base(type, name, model, price). This caused an error for the car and motorbike classes because the parameters need to be in the correct order the entire way through the program. 
         

        {
            numOfCars++;
        }

        public void SoldCar(bool isSold, int Price)
        {
            SoldOneVehicle(isSold, price);

            numOfCars--;

        }
        

    }

    class Motorbike : Vehicle
    {
        public static int numOfBikes;

        public Motorbike(string name, string model, int price, string type = "bike") : base(name, model, price, type)

        {
            numOfBikes++;
        }

        public void SoldBike(bool isSold, int Price)
        {
            SoldOneVehicle(isSold, price);

            numOfBikes--;

        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> allVehicles = new List<Vehicle>();

            Car.numOfCars = 0;
            Motorbike.numOfBikes = 0;

            Car car1 = new Car("RollsRoyce", "Silver Cloud", 35000);
            allVehicles.Add(car1);

            Car car2 = new Car("Aston Martin", "DB5", 750000);
            allVehicles.Add(car2);

            Car car3 = new Car("Reliant", "Robin", 550);
            allVehicles.Add(car3);

            Motorbike bike1 = new Motorbike("Triumph", "Tiger 800", 10000);
            allVehicles.Add(bike1);

            Motorbike bike2 = new Motorbike("Vespa", "Sprint 150", 2500);
            allVehicles.Add(bike2);

           
            Console.WriteLine("Total number of cars in stock is: {0}", Car.numOfCars);
            Console.WriteLine("Total number of motorbikes in stock is: {0}", Motorbike.numOfBikes);
            Console.WriteLine();

            Vehicle.DisplayAllVehicles(allVehicles);

            //record the sale of a car and a bike
            car2.SoldCar(true, 650000);
            bike1.SoldBike(true, 10000);

            //display cars data
            Console.WriteLine("Total number of cars in stock is: {0}", Car.numOfCars);
            Console.WriteLine("Total number of motorbikes in stock is: {0}", Motorbike.numOfBikes);
            Console.WriteLine();

            Vehicle.DisplayAllVehicles(allVehicles);
        }
    }
}
