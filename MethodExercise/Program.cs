using System;

namespace MethodExercise
{
    class MainClass
    {
        public static int Sum(int num1, int num2)
        {
            var answer = num1 + num2;
            return answer;
        }

        public static int Multiply(int num1, int num2)
        {
            
            return num1 * num2;
        }

        public static void Main(string[] args)
        {

            //------------Exercise 2------------

            var ammountOfCars = Sum(2, 6);

            var ammountOfBeans = Multiply(10, 2);

            //------------Exercise 2------------


            //------------Exercise 1------------
            //Name: Michael
            //Favorite Color: Blue
            //Favorite Animal: Walrus
            //Favorite Band: The Beatles

            Console.WriteLine("Hello, What is your first name?");
            var userName = Console.ReadLine();

            Console.WriteLine($"Hi {userName}. What is your favorite Color");
            var color = Console.ReadLine();

            Console.WriteLine($"{color} is an unique color. What is your favorite animal?");
            var animal = Console.ReadLine();

            Console.WriteLine($"{animal} are GREAT!!! What is your favorite Band?");
            var bandName = Console.ReadLine();

            Console.WriteLine($"Thanks, {userName}! Here is your profile");
            Console.WriteLine($"----------------------------------------");

            Console.WriteLine($"Name: {userName}");
            Console.WriteLine($"Favorite Color: {color}");
            Console.WriteLine($"Favorite Animal: {animal}");
            Console.WriteLine($"Favorite Band: {bandName}");


            

        }
    }
}
