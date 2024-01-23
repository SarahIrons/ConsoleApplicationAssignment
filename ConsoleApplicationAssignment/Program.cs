using System;

namespace ConsoleApplicationAssignment
{
    class AppDomain
    {
        static bool Main(string[] args)
        {
            //Takes an input from the user, multiplies it by 50, then prints the result to the console. (Note: make sure your code can take inputs larger than 10, 000, 000).
            Console.WriteLine("Provide a number and we will multiply it by 50:");
            var num = int.Parse(Console.ReadLine());
            var product = num * 50;
            Console.WriteLine(product);

            //Takes an input from the user, adds 25 to it, then prints the result to the console.
            Console.WriteLine("Next, let's take another number and add 25 to it:");
            var A = int.Parse(Console.ReadLine());
            var sum = A + 25;
            Console.WriteLine(sum);

            //Takes an input from the user, divides it by 12.5, then prints the result to the console.
            Console.WriteLine("Now, give a number, we will divide it by 12.5:");
            var B = int.Parse(Console.ReadLine());
            product = (int)(B / 12.5);

            Console.WriteLine(product);

            //Takes an input from the user, checks if it is greater than 50, then prints the true / false result to the console.
            Console.WriteLine("Provide a number. The program will check if the number is greater than 50 and give a true/false report back.");
            var C = int.Parse(Console.ReadLine());
            if C > 50
{
                Console.Write("Your number is greater than or equal to 50.");
            }
            else
            {
                C <= 50
}

            Console.Write("Your number is less than 50.");
            
            //Takes an input from the user, divides it by 7, then prints the remainder to the console(tip: think % operator).
            Console.WriteLine("We will divide a number by 7:");
            var D = int.Parse(Console.ReadLine());
            Console.WriteLine(D/7);

        }
    }
}
