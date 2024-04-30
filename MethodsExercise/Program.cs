using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace MethodsExercise
{
    public class Program
    {


            static void Main(string[] args)
            {
                var amountofcars = Sum(2, 6);
                var blah = Multiply(60, 2, 4);

                //----------------Exercise 1------------------
                //Name: Michael
                //Favorite Color: Blue
                //Favorite Animal: Walrus
                //Favorite Band: The Beatles

                Console.WriteLine("Hello - What is your first name?");
                var username = Console.ReadLine();

            Console.WriteLine($"Hi, {username}. What is your favorite color?");
                var color = Console.ReadLine();

                Console.WriteLine($"{color} is an awesome color! - What is your faavorite animal?");
                var animal = Console.ReadLine();

                Console.WriteLine("Great! Now, what is your favorite band?");
                var band = Console.ReadLine();

                Console.WriteLine($"Thanks, {username}! Here is your profile");
                Console.WriteLine("---------------");

                Console.WriteLine($"Name: {username}");
                Console.WriteLine($"Favorite Color: {color}");
                Console.WriteLine($"Favorite Animal: {animal}");
                Console.WriteLine($"Favorite Band: {band}");

                //------------------Exercise 2----------------------











            }

            static int Multiply(int num1, int num2, int num3)

            { return num1 * num2 * num3; }

        static int Sum(int num1, int num2)
        {
            var answer = num1 + num2;
            return answer;
        }
    }
}
