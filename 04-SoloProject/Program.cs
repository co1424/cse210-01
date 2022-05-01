// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Check link for Solo 4:
//https://byui-cse.github.io/cse210-course-csharp/module01/solo_prep_4_prepare.html
using System;
using System.Collections.Generic;

int userNumber = -1;
List<int> numbers = new List<int>();
while (userNumber != 0)
{
    Console.Write("Enter a number (0 to quit): ");
    
    string userResponse = Console.ReadLine();
    userNumber = int.Parse(userResponse);
    
    numbers.Add(userNumber);
}

// Part 1: Compute the sum
int sum = 0;
foreach (int number in numbers)
{
    sum += number;
}

Console.WriteLine($"The sum is: {sum}.");

// Part 2: Compute the average
float average = sum / numbers.Count;
Console.WriteLine($"The average is: {average}");

// Part 3: Find the max
// There are several ways to do this, such as sorting the list
            
int max = numbers[0];

foreach (int number in numbers)
{
    if (number > max)
    {

        // if this number is greater than the max, we have found the new max!
        max = number;
    }
}

Console.WriteLine($"The max is: {max}");
