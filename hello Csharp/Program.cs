using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hello_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello world");
            Console.WriteLine("Please enter 2 numbers to multiply");
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

           
            int result = number1 * number2;
            Console.WriteLine("the result is:" + result);
            Console.ReadLine();

        }
    }
}
