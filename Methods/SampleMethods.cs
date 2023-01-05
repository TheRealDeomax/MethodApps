using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal static class SampleMethods
        //static means - it allows you to make a call directly to the method without having to set things up first called instatiation
    {
        public static void SayHi(int number)
        {
            Console.WriteLine($"{number} Hello World!");
        }
        public static void SayHi()
        {
            Console.WriteLine("Hello World!");
        }
    }
}
