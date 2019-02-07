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
            Console.WriteLine("Enter one of the following number to explore the design pattern");
            Console.WriteLine("1- Singleton Pattern");
            Console.WriteLine("2- Singleton Thread Safety with lock Pattern");
            string value = Console.ReadLine();
            switch (value)
            {
                case "1":
                    Singleton objectA = Singleton.GetInstance;
                    objectA.PrintDetails("This is from Object A");
                    Singleton objectB = Singleton.GetInstance;
                    objectA.PrintDetails("This is from Object B");
                    //Uncomment following code if we want to test why we need to seal our class.
                    //Singleton.DerivedSingleton derivedObj = new Singleton.DerivedSingleton();
                    //derivedObj.PrintDetails("From Derived");
                    break;
                case "2":
                    Parallel.Invoke(
                        () => PrintObjectA1Details(),
                        () => PrintObjectB1Details()
                        );

                    break;
                case "D":
                    break;
            }
            Console.Read();
        }

        private static void PrintObjectB1Details()
        {
            Singleton objectB1 = Singleton.GetInstance;
            objectB1.PrintDetails("This is from Object B1, Thread Safety");
        }

        private static void PrintObjectA1Details()
        {
            Singleton objectA1 = Singleton.GetInstance;
            objectA1.PrintDetails("This is from Object A1, Thread Safety");
        }
    }
}
