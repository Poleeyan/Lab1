using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdTry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // first
            string name = "Столовник Володимир";
            int age = 18;
            Console.WriteLine("Привiт, мене звати {0}, менi {1} рокiв", name, age);

            // second
            // a*a -- Math.Pow(a,2)
            //Console.Write(result)
            int a = 3;
            int b = 8;
            double result;
            result = (Math.Pow(a+b,4))-(Math.Pow(a,4))+4*(Math.Pow(a,3))*b+6*(Math.Pow(a,2))*(Math.Pow(b,2))/(Math.Pow(b,2))*4*a+(Math.Pow(b,4));
            Console.WriteLine("result = {0}", result);
            //Console.WriteLine($"result = {result}");


            Console.ReadKey(true);
        }
    }
}
