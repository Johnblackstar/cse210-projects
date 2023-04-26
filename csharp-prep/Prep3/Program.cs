using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,11);
     
        Console.WriteLine("What is the Magic Number");
        string userInput = Console.ReadLine();
        int guess = -1;
     
        

        while (guess !=number)
        {
            Console.WriteLine("What is the Magic Number? ");
            guess = int.Parse(Console.ReadLine());
            
            
            if ( guess < number)
            {
                Console.WriteLine ("Higher");
            }
                
            else if (guess > number)
            {
                Console.WriteLine("Lower");
            }
            else
            {
               
                Console.WriteLine("Congratulation you guessed it");
                Console.WriteLine($"It took you {guess} guesses");
            }
        }    

    }
    
}