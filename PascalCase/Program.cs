using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 4- Write a program and ask the user to enter a few words separated by a space.
 * Use the words to create a variable name with PascalCase. For example, 
 * if the user types: "number of students", display "NumberOfStudents". 
 * Make sure that the program is not dependent on the input.
 * So, if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents".
 */
namespace PascalCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a few words: ");
            var input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Error");
                return;
            }

            var variable = "";
            foreach (var word in input.Split(' '))
            {
                var words = char.ToUpper(word[0]) + word.ToLower().Substring(1);
                variable += words;
            }

            Console.WriteLine(variable);
        }
    }
}
