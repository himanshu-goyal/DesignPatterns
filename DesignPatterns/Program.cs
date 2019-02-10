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
                        () => SingletonHelper.PrintObjectA1Details(),
                        () => SingletonHelper.PrintObjectB1Details()
                        );
                    break;
                case "3":
                    SingletonEager objectAE = SingletonEager.GetInstance;
                    objectAE.PrintDetails("This is from eager loading, obeject AE");
                    SingletonEager objectBE = SingletonEager.GetInstance;
                    objectAE.PrintDetails("This is from eager loading, obeject BE");
                    break;
                case "D":
                    break;
            }
            Console.Read();
        }

    }
}
