using System;
using System.Collections.Generic;

namespace Lab6_4
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskScheduler<string, int> scheduler = new TaskScheduler<string, int>(ExecuteTask);

            while (true)
            {
                Console.WriteLine("Enter a task (or 'exit' to quit):");
                string input = Console.ReadLine();

                if (input.Equals("exit", StringComparison.OrdinalIgnoreCase))
                    break;

                Console.WriteLine("Enter task priority:");
                if (int.TryParse(Console.ReadLine(), out int priority))
                {
                    scheduler.AddTask(input, priority);
                }
                else
                {
                    Console.WriteLine("Invalid priority. Task not added.");
                }
            }

            scheduler.ExecuteNext();
        }

        static void ExecuteTask(string task)
        {
            Console.WriteLine($"Executing task: {task}");
        }
    }
}
