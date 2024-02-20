using System.Runtime.CompilerServices;

namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        static void PositiveToNegative()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }
        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        static void PrintByThree()
        {
            for (int i = 3; i <=999; i+=3)
            {
                Console.WriteLine(i);
            }
        }

        //Write a method to accept two integers as parameterss and check whether they are equal or not
        static bool CheckEqual(int numOne, int numTwo)
        {
            return numOne == numTwo;
        }

        //Write a method to check whether a given number is even or odd
        static bool CheckEvenOdd(int numEvenOdd)
        {
            return numEvenOdd % 2 == 0;
        }

        //Write a method to check whether a given number is positive or negative
        static string CheckPositiveNegative(int numPositiveNegative)
        {
            if (numPositiveNegative > 0)
            {
                return "positive";
            }
            else if (numPositiveNegative < 0)
            {
                return "negative";
            }
            else
            {
                return "zero";
            }
        }

        //Write a method to read the age of a candidate and determine whether they can vote.
        static void CheckCanVote(string ageString)
        {
            int age = int.Parse(ageString);

            if (age >= 18)
            {
                Console.WriteLine("You can vote.");
            }
            else
            {
                Console.WriteLine("You can't vote yet.");
            }

        }
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        static void CheckTenToTen(string rangeString)
        {
            int range = int.Parse(rangeString);
            if (range >= -10 && range <= 10)
            {
                Console.WriteLine($"{range} is within the range of -10 to 10.");
            }
            else
            {
                Console.WriteLine($"{range} is out of the range of -10 to 10.");
            }
        }
        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        static void MultiplicationTable(string tableString)
        {
            int multiTable = int.Parse(tableString);
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{multiTable} x {i} = {multiTable * i}");
            }
        }

        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            //Method One
            PositiveToNegative();
            //Method Two
            PrintByThree();
            //Method Three
            Console.WriteLine("Input two integers to compare if equal or not:");
            int numOne = Convert.ToInt32(Console.ReadLine());
            int numTwo = Convert.ToInt32(Console.ReadLine());
            if (CheckEqual(numOne, numTwo))
            {
                Console.WriteLine($"{numOne} is equal to {numTwo}");
            }
            else
            {
                Console.WriteLine($"{numOne} is not equal to {numTwo}");
            }
            //Method Four
            Console.WriteLine("Input an integer to check if it's even or not:");
            int numEvenOdd = Convert.ToInt32(Console.ReadLine());
            if (CheckEvenOdd(numEvenOdd))
            {
                Console.WriteLine($"{numEvenOdd} is even.");
            }
            else
            {
                Console.WriteLine($"{numEvenOdd} is odd.");
            }
            //Method Five
            Console.WriteLine("Input an integer to check if it's positive or not:");
            int numPositiveNegative = Convert.ToInt32(Console.ReadLine());
            string PositiveNegative = CheckPositiveNegative(numPositiveNegative);
            Console.WriteLine($"The number {numPositiveNegative} is {PositiveNegative}");
            //Method Six
            Console.WriteLine("Input an integer as your age:");
            string ageString = Console.ReadLine();
            CheckCanVote(ageString);
            //Method Seven
            Console.WriteLine("Input an integer to check if the number is in the range of -10 to 10");
            string rangeString = Console.ReadLine();
            CheckTenToTen(rangeString);
            //Method Eight
            Console.WriteLine("Give an integer 1 to 12 to show the multiplication table of the integer:");
            string tableString = Console.ReadLine();
            MultiplicationTable(tableString);


        }
    }
}
