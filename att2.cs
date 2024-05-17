using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att2
{
    class Program
    {
        static double hipotenusa(double a , double b)
        {
            return Math.Sqrt( (a * a) + (b * b));
        }

        static void Main(string[] args)
        {
            Console.WriteLine("De o valor de A");
            double A = int.Parse(Console.ReadLine());
            Console.WriteLine("De o valor de B");
            double B = int.Parse(Console.ReadLine());


            Console.WriteLine($"o valor da hipotenusa e : {hipotenusa(A,B)}");



            Console.ReadLine();
        }
    }
}
