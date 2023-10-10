// See https://aka.ms/new-console-template for more information
// using System;

// Console.WriteLine("Hello, World!");

namespace ConsoleApp1
{
    internal class Program
    {
        private int num { get; set; }

        string name { get; set; }

        private string userName { get; set; }

        public static void Main(string[] args)
        {
            var program = new Program();
            
            Console.WriteLine(program.userName);
            // var foo = Array<int>();
            // Console.WriteLine(foo);
            Console.WriteLine("Hello World!");
            // program.ame("William");
            Console.WriteLine($"{program.num}: {program.name}");
            Console.WriteLine(Convert.ToBoolean(program.num));
            
            Console.Write("Enter username: ");
            var userName = Console.ReadLine();
            
            Console.WriteLine(string.Concat(userName, program.name));
            myMethod();
            var a = myMethod(2);
            Console.WriteLine(a);
        }

        static void myMethod()
        {
            Console.WriteLine("Static method");
        }

        static int myMethod(int a)
        {
            return a;
        }
    }
}