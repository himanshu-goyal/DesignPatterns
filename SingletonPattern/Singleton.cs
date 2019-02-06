using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public sealed class Singleton
    {
        //Private prop as this will be only initiized with null and make sure only one instance is there.
        private static Singleton instance=null;
        private static int counter = 0;

        public static Singleton GetInstance
        {
            get
            {
                if(instance==null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }
        
        //Private construct, this will give us number of object initilized.
        private Singleton()
        {
            counter++;
            Console.WriteLine("Constructor called,Counter value: " + counter.ToString());
        }
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }

        //This class was created to understand why we need to seal our base class.
        //We will create an instance of derived class and we will see that counter will increase to 2
        //That will viloate out singleton pricipal. 
        //public class DerivedSingleton : Singleton
        //{

        //}
    }
}
