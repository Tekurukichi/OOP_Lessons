using System;
using System.Collections.Generic;

namespace Lab6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Repository<string> stringRepository = new Repository<string>();

            stringRepository.Add("Henry");
            stringRepository.Add("Germans");
            stringRepository.Add("Allah");
            stringRepository.Add("Decimal");

            Criteria<string> criteria = item => item.Length <= 5;

            List<string> result = stringRepository.Find(criteria);

            Console.WriteLine("Elements with length less than or equal to 5:");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}