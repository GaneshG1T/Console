//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//int[] num = { 1, 10, 2, 7, 4, 6};
//Array.Sort(num);
//int j = 0;

//for (int i = 1; i <= 10; i++)
//{
//    int S = num.Length;
//    if (j < S && num[j] == i)
//    {
//        Console.WriteLine("Given Numbers:" + i);
//        j++;
//    }
//    else
//    {  
//        Console.Write("Missing Number:" + i);
//    }

//}
using System;  // Importing necessary namespace

public class Exercise2  // Declaration of the Exercise2 class
{
    public static void Main()  // Main method, entry point of the program
    {
        int j, sum = 0;  // Declaration of variables 'j' for iteration and 'sum' to store the total sum

        Console.Write("\n\n");  // Displaying new lines
        Console.Write("Find the sum of the first 10 natural numbers:\n");  // Displaying the purpose of the program
        Console.Write("----------------------------------------------");  // Displaying a separator
        Console.Write("\n\n");

        Console.Write("The first 10 natural numbers are:\n");

        for (j = 1; j <= 10; j++)  // Loop to calculate the sum of the first 10 natural numbers
        {
            sum = sum + j;  // Adding each number to the sum
            Console.Write("{0} ", j);  // Printing each natural number
        }

        Console.Write("\nThe Sum is : {0}\n", sum);  // Displaying the total sum of the first 10 natural numbers
    }
}
