using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att1
{
    class Program
    {
        static double Menor(double[] v)
        {
            double menor = v[0];

            double[] vetor = new double[4];
            for (int i = 0; i < 4; i++)
            {
              if (menor > v[i])
                {
                    menor = v[i];
                }

            }

            return menor;


        }

        static void Main(string[] args)
        {
            Console.WriteLine("Digite 4 numeros");

            double[] vetor = new double[4];
            for(int i = 0; i < 4; i ++ )
            {
                Console.Write($"Digite o {i + 1} numero :");
                vetor[i] = double.Parse(Console.ReadLine());
            }

            Console.Write($"o menor valor e : {Menor(vetor)}");


            Console.ReadLine();

        }
    }
}
