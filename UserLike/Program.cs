using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that prompts the user asking who they are and what they like; then print the statements back to the user with their input

namespace UserLike
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What is something you like to do?");
            string hobby = Console.ReadLine();
            Console.WriteLine(Hobby(name, hobby));

        }

        static public string Hobby(string name, string hobby)
        {
            Console.WriteLine($"Hello, you are {name}, and you like to {hobby}");
            return null;
        }
    }
}
