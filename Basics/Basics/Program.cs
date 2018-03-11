/* Create by Joe Wong
 * For CS4330 Challenge 7
 * 3/10/2018
 */

using System;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            const byte sample1 = 0x3A;
            byte sample2 = 58;
            var heartRate = 85;
            double deposits = 135002796;
            const float acceleration = 9.800f;
            float mass = 14.6f;
            double distance = 129.763001;
            bool lost = true, expensive = true;
            int choice = 2;
            const char integral = '\u222B';
            const string greeting = "Hello";
            string name = "Karen";

            Console.WriteLine(sample1 == sample2 ? "The samples are equal." : "The samples are not equal.");
            if(heartRate >= 40 && heartRate <= 80){
                Console.WriteLine("Heart rate is normal.");
            } else {
                Console.WriteLine("Heart rate is not normal.");
            }
            Console.WriteLine(deposits >= 100000000 ? "You are exceedingly wealthy." : "Sorry you are so poor.");
            var force = mass * acceleration;
            Console.WriteLine($"force = {force}");
            Console.WriteLine($"{distance} is the distance.");
            if(lost){
                if(expensive){
                    Console.WriteLine("I am really sorry! I will get the manager.");
                } else {
                    Console.WriteLine("Here is coupon for 10% off.");
                }
            }
            switch (choice){
                case 1:
                case 2:
                case 3: 
                    Console.WriteLine($"You chose {choice}.");
                    break;
                default: 
                    Console.WriteLine("You made an unknown choice.");
                    break;
            }
            Console.WriteLine(integral + " is an integral.");
            for (int i = 5; i <= 10; i++){
                Console.WriteLine("i="+i);
            }
            int age = 0;
            while(age < 6){
                Console.WriteLine("age =" + age++);
            }
            Console.WriteLine(greeting + " " + name);
        }
    }
}
