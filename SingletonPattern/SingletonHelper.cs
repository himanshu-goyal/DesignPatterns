using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public static class SingletonHelper
    {
        public static void PrintObjectB1Details()
        {
            Singleton objectB1 = Singleton.GetInstance;
            objectB1.PrintDetails("This is from Object B1, Thread Safety");
        }

        public static void PrintObjectA1Details()
        {
            Singleton objectA1 = Singleton.GetInstance;
            objectA1.PrintDetails("This is from Object A1, Thread Safety");
        }
    }
}
