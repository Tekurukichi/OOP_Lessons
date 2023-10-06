using System;
using System.Runtime.CompilerServices;
using System.Text.Encodings;
namespace Lab1_04
{
    class Program
    {
        static void Main(string[] args)
        {
            User.Quiz();
            
            
            

            Console.WriteLine($"Date Quiz Execution: {User.DateQuiz.ToString("dd MMMM yyyy")}\n" +
                              $"Login: {User.Login}\n" +
                              $"Name: {User.Name}\n" +
                              $"Surname: {User.Surname}\n" +
                              $"Age: {User.Age}\n");
            //Console.WriteLine($"Login: {User.Login} ");
        }
    }
}