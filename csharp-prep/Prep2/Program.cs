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
        string symbol = "";
      
          

        if ( lastDigit > 7)
        {
            symbol = " + ";
        }
        
        else if (lastDigit > 7 && grade >93 || grade < 60)
        {
            symbol= ("");
        }
        else if (lastDigit<3)
        {
            symbol = ("-");
        }
        else 
        {
            symbol = ("");
        }

       

        if (grade >=90)


        {   
            Console.WriteLine($"Your grade is A {symbol} ");
            Console.WriteLine("Congratulation you passed");
        }
        else if ( grade >= 80)
        {
            Console.WriteLine($"Your grade is B {symbol}");
            Console.WriteLine("Congratulation you passed");
        }

        else if ( grade >= 70)
        {
            Console.WriteLine($"Your grade is C {symbol}");
            Console.WriteLine("Congratulation you passed");
        }

        else if ( grade >= 60)
        {
            Console.WriteLine($"Your grade is D {symbol}");
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