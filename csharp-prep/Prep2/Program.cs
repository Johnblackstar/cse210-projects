using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.Write("What is your Grade?");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);
        int lastDigit = grade % 10;

        if (lastDigit > 7)
        {
            Console.Write("+");
        }
        else if (lastDigit > 7 && grade >93 || grade < 60)
        {
            Console.Write("");
        }
        else if (lastDigit<3)
        {
            Console.Write("-");
        }
        else 
        {
            Console.Write("");
        }
       

        if (grade >=90)

        {   
            Console.WriteLine($"Your grade is A {lastDigit} ");
            Console.WriteLine("Congratulation you passed");

        }
        else if ( grade >= 80)
        {
            Console.WriteLine($"Your grade is B {lastDigit}");
            Console.WriteLine("Congratulation you passed");
        }

        else if ( grade >= 70)
        {
            Console.WriteLine($"Your grade is C {lastDigit}");
            Console.WriteLine("Congratulation you passed");
        }

        else if ( grade >= 60)
        {
            Console.WriteLine($"Your grade is D {lastDigit}");
            Console.WriteLine("Your grade did not meet the expectation. Better luck next time!");
        }   

        else if ( grade <60)
        {
            Console.WriteLine("Your grade is F");
            Console.WriteLine("Your grade did not meet the expectation. Better luck next time!");
        }

        else
        {
            Console.WriteLine("Your grade did not meet the expectation. Better luck next time!");      
        }
    }
}