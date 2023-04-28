using System;

class Program
{
    static void Main(string[] args)
    
    
    {
        List<int> numbers = new List<int>();
        int number =-1;
    

        
        while (number != 0)
        
        {    
            Console.WriteLine("Enter a list of numbers, type 0 when finished"); 
            string userInput = Console.ReadLine();
            number = int.Parse(Console.ReadLine());
            if (number!= 0)
            {
                numbers.Add(number);
            }
        }
        // Part 1 : Compute the sum 
        int sum = 0;

        foreach (int userNumber in numbers)
        {
            sum += userNumber;
        } 
        Console.WriteLine($"The sum is:{sum}");

        // Part 2 : Compute the average 
        float average = ((float)sum) /numbers.Count;
        Console.WriteLine($"The average is :{average}");

        // Part 3: Find the max

        int max = numbers[0];
        foreach (int userNumber in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine ($"The max is: {max}");

    }


    
}