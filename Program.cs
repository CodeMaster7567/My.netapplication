using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<string> tasks = new List<string>();
        string input;

        Console.WriteLine("Task Manager - To-Do List");
        Console.WriteLine("Enter tasks, type 'exit' to finish:");

        while (true)
        {
            Console.Write("Task: ");
            input = Console.ReadLine();

            if (input.ToLower() == "exit")
                break;

            tasks.Add(input);
        }

        Console.WriteLine("\nYour Tasks:");
        foreach (var task in tasks)
        {
            Console.WriteLine("- " + task);
        }
    }
}
