using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedCameraProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the speed limit");
            int speedLimit = Convert.ToInt32(Console.ReadLine());
            List<Car> carList = new List<Car>();
            for (; ; )
            {
                carList.Clear();
                Console.Clear();
                Console.WriteLine("Please enter the number of cars you would like to track");
                int numberOfCars = Convert.ToInt32(Console.ReadLine());
           

       

                for (int i = 1; i <= numberOfCars; i++)
                {
                    Console.Clear();
                    Car car = new Car();
                    Console.WriteLine("Please Enter Car #" + i.ToString() + " Make");
                    car.make = Console.ReadLine();
                    Console.WriteLine("Please Enter Car #" + i.ToString() + " Model");
                    car.model = Console.ReadLine();
                    Console.WriteLine("Please Enter Car #" + i.ToString() + " Speed");
                    car.speed = Convert.ToInt32(Console.ReadLine());
                   

                    if (car.speed <= speedLimit)
                    {
                        car.status = "OK";
                    }
                    else
                    {
                        int demeritPoints = (car.speed - speedLimit) / 5;
                        car.demeritPoints = demeritPoints;
                        if (car.demeritPoints > 10)
                        {
                            car.status = "<LICENSE SUSPENDED>";

                        }

                    }


                    carList.Add(car);
                }
                Console.Clear();
                Console.WriteLine("Speed Limit: " + speedLimit + "mph");
                foreach (var item in carList)
                {
                    if (item.demeritPoints == 0)
                    {
                        Console.WriteLine(item.make + " " + item.model + " " + item.speed + "mph:" + item.status);
                    }
                    else
                    {
                        if (item.speed > (speedLimit + 10))
                        {

                            Console.WriteLine(item.make + " " + item.model + " " + item.speed + "mph:" + item.demeritPoints + " demerits " + item.status);
                        }
                        else
                        {
                            Console.WriteLine(item.make + " " + item.model + " " + item.speed + "mph:" + item.demeritPoints + " demerits ");
                        }
                    }

                }
                Console.WriteLine("Press Any Key To Continue");
                Console.ReadLine();


            }

        }
    }
}
