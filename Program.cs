using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace jibbol
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("       /|");
            //Console.WriteLine("      / |");
            //Console.WriteLine("     /  |");
            //Console.WriteLine("    /   |");
            //Console.WriteLine("   /    |");
            //Console.WriteLine("  /_____|");

            string name = "Habeeb";
            int age;
            age = 34;

            /*Console.WriteLine("There was a man named " + name);
            Console.WriteLine("He was "+ age + " years old");
            Console.WriteLine("He really like the \"name " + name.ToLower());
            Console.WriteLine("But he don't like the age " + age);
            Console.WriteLine("The name character has " + name.Length + " characters");
            Console.WriteLine(name.Substring(4, 2) );*/

            /* Console.Write("Hey! whats your name?");
             string newName = Console.ReadLine();
             Console.WriteLine("Hey there! " + newName + " welcome");*/

            Console.Write("Enter a Number! ");

            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter another Number! ");

            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The addition of two numbers are: " + num1 + num2);


            Console.ReadLine();
        }
    }
}
