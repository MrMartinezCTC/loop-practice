using System;

class Program
{
    static void Main(string[] args)
    {
        Write1ThroughN_While();

        Write1ThroughN_For();

        WriteNThrough1_While();

        WriteNThrough1_For();

        WriteEvensThrough100();

        FindSum();

        FindSumOfEvenNumbers();

        FindSumOfOddNumbers();
    }

    public static void Write1ThroughN_While()
    {
        // Use a while loop to write all numbers 1 through n, where 'n' is a positive integer provided by the user
    }
    public static void Write1ThroughN_For()
    {
        // Use a for loop to write all numbers 1 through n, where 'n' is a positive integer provided by the user
    }
    public static void WriteNThrough1_While()
    {
        // Use a while loop to write all numbers in reverse n through 1, where 'n' is a positive integer provided by the user
    }
    public static void WriteNThrough1_For()
    {
        // Use a for loop to write all numbers in reverse n through 1, where 'n' is a positive integer provided by the user
    }

    public static void WriteEvensThrough100()
    {
        // Use a loop of your choice to write all even numbers from 1 to 100
    }

    public static void FindSum()
    {
        // Use a loop of your choice to find the sum of all numbers from 1 through n, where 'n' is 
        // a positive integer provided by the user.
        // ex) if the user chooses 5 the output will be 1 + 2 + 3 + 4 + 5 = 15
    }
    public static void FindSumOfEvenNumbers()
    {
        // Use a loop of your choice to find the sum of all even numbers from 1 through n, where 'n' is 
        // a positive integer provided by the user.
        // ex) if the user chooses 8 the output will be 2 + 4 + 6 + 8 = 20
    }

    public static void FindSumOfOddNumbers()
    {
        // Use a loop of your choice to find the sum of all odd numbers from 1 through n, where 'n' is 
        // a positive integer provided by the user.
        // ex) if the user chooses 8 the output will be 2 + 4 + 6 + 8 = 20
    }
}