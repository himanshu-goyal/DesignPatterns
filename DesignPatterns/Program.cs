using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SingletonPattern;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter one of the chars from following to explore the design pattern");
            char value = Convert.ToChar(Console.ReadLine());
            switch (value)
            {
                case 'S':
                    Singleton objectA = Singleton.GetInstance;
                    objectA.PrintDetails("This is from Object A");
                    Singleton objectB = Singleton.GetInstance;
                    objectA.PrintDetails("This is from Object B");
                    break;
                case 'D':
                    break;
            }
            Console.Read();
        }
    }
}
