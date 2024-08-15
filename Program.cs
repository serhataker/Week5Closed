using System;
using Week5Closed;

namespace Week5
{

    class Program
    {

        static void Main(string[] args)
        {

            List<Car> list = new List<Car>(); // we created the list object

            while (true) // start the while loop
            {


                Console.WriteLine("Do you want to new product (Y/N)"); // we ask the user do you want to product
                string Ans = Console.ReadLine();


                if (Ans.ToLower() == "n") // if user choose the N or n
                {

                    Console.WriteLine("GoodBye your Car's list information"); // we message our car's list and ended program
                    break;
                }
                else if (Ans.ToLower() == "y") // if user choose the Y or y
                {
                    // Product
                    Car car = new Car(); // we create the object at the car class and take it the user answer

                    car.ProductDate = DateTime.Now; // we assign the default time to the production
                    Console.WriteLine("Please enter serial number");
                    car.SerialNumber = Console.ReadLine();
                    Console.WriteLine("Please enter Brand");
                    car.Brand = Console.ReadLine();
                    Console.WriteLine("Please enter Model ");
                    car.Model = Console.ReadLine();
                    Console.WriteLine("Please enter Color");
                    car.Color = Console.ReadLine();

                    gate:// we created the gate if user dont input numeric
                    try
                    {
                        Console.WriteLine("Please enter Gate Number");
                        car.GateNumber = Convert.ToInt32(Console.ReadLine());
                       

                    }
                    catch (FormatException ex)
                    {

                        Console.WriteLine("please input the number charcter"); // we give the message if user choose dont numeric number
                            goto gate;// goto the gate
                        }
                    


                    list.Add(car);// we assign the all properties car object list

                }
                else
                {

                    Console.WriteLine("you are mistake please try again"); //if user choose dont Y or N 
                }

                
            }


            int index = 1; // we create the index number
            foreach (var cars in list) // we return the all cars object at the foreach 
            {

                Console.WriteLine($"{index}- Serial:{cars.SerialNumber} Brand:{cars.Brand}"); //Print the number with serial number and brand
                index++;
            }

        }
    }
}