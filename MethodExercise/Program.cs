using System;

namespace MethodExercise
{
    class MainClass
    {
        public static void Main(string[] args)
        {
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

            Console.WriteLine($"That {animal} is GREAT!!! What is your favorite Band?");
            var bandName = Console.ReadLine();
        }
    }
}
