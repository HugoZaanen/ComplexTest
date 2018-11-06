using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //propt the user to enter first complex number
            Console.Write("Enter the real part of complex number x:");
            double realPart = double.Parse(Console.ReadLine());
            Console.Write("Enter the imaginary part of complex number x:");
            double imaginaryPart = double.Parse(Console.ReadLine());
            var x = new ComplexNumber(realPart, imaginaryPart);

            //prompt the user to enter the second complex number
            Console.Write("\nenter the real part of complex number");
            realPart = double.Parse(Console.ReadLine());
            Console.Write("Enter the imaginary part of complex number y:");
            imaginaryPart = double.Parse(Console.ReadLine());
            var y = new ComplexNumber(realPart, imaginaryPart);

            //display the results of calculations with x and y
            Console.WriteLine();
            Console.WriteLine($"{x} + {y} = {x + y}");
            Console.WriteLine($"{x} - {y} = {x - y}");
            Console.WriteLine($"{x} * {y} = {x * y}");
            Console.Read();
        }
    }
}
