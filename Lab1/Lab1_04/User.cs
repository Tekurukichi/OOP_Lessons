using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.RegularExpressions;


namespace Lab1_04
{
    public class User
    {
        
        private static string _login;
        public static string Login { get => _login;
            set { _login = value; }
        }
        
        private static string _name;
        public static string Name { get => _name;
            set { _name = value; }
        }
        
        private static string _surname;
        public static string Surname { get => _surname;
            set { _surname = value; }
        }
        
        private static int _age;
        public static int Age { get => _age;
            set { _age = value; }
        }
        
        private static DateTime _dateQuiz; // Дата проходження анкетування
        public static DateTime DateQuiz {get => _dateQuiz;
            set => _dateQuiz = value;
        }
        
        public static void Quiz()
        {
            try
            {
            
                Console.Write("Input Login: ");
                Login = Convert.ToString(Console.ReadLine());
                
                Console.Write("Input Name: ");
                Name = Console.ReadLine();
                Regex.IsMatch(Name, @"^[a-zA-Z]+$");
                

                Console.Write("Input Surname: ");
                Surname = Console.ReadLine();
                Regex.IsMatch(Surname, @"^[a-zA-Z]+$");
               
                Console.Write("Input age: ");
                Age = Convert.ToInt32(Console.ReadLine());
                
                Console.WriteLine("Input Date Quiz Execution(y/m/d): ");
                DateQuiz = new DateTime(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()),
                Convert.ToInt32(Console.ReadLine()));
            } catch (Exception)
            {
                Console.WriteLine("Wrong value"); Quiz();
            }
        }
    }
    
}