using System;
using ClassLibrary2;

namespace CarRental
{
    internal class Program
    {
        static void Main()
        {
            Car[] cars = new Car[3]
            {
                new Car("Toyota", "Corolla", 50,false),
                new Car("Honda","Civic",60,false ),
                new Car("Ford", "Mustang",80,false )
            };
            Console.WriteLine("Welcome to the car rental system!");
            int choice = -1;
            do
            {
                Console.WriteLine();
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Rent a car");
                Console.WriteLine("2. Return a car");
                Console.WriteLine("3. View available cars");
                Console.WriteLine("4. Exit");
                Console.WriteLine();
                Console.Write("Ente your choice:");
                Console.WriteLine();
                choice = Convert.ToInt32(Console.ReadLine());

                switch(choice)
                {
                    case 1:
                        {
                            Console.WriteLine("Rent a Car:");
                            int carId = 1;
                            foreach(Car car in cars)
                            {
                                Console.Write(carId);
                                car.PrintInfo();
                                carId++;
                            }
                            Console.Write("Please enter the ID of the car you want to rent: ");
                            carId=Convert.ToInt32(Console.ReadLine());
                            cars[carId - 1].Rent();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Return a Car:");
                            int carId = 1;
                            foreach (Car car in cars)
                            {
                                Console.Write(carId);
                                car.PrintInfo();
                                carId++;
                            }
                            Console.Write("Please enter the ID of the car you want to return: ");
                            carId = Convert.ToInt32(Console.ReadLine());
                            cars[carId - 1].Return();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Available Cars:");
                            int carId = 1;
                            foreach (Car car in cars)
                            {
                                if(car.Available)
                                {
                                    Console.Write(carId);
                                    car.PrintInfo();
                                    carId++;
                                }
                            }
                            break;
                            
                        }
                }
            } while (choice != 4);


        }
    }
}
