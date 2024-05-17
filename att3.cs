using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att3
{
    class Program
    {
        static int MMC(int n1 , int n2)
        {

            int mmc = 1;
            int i = 2;

            while (n1 > 1 || n2 > 1)
            {
                if (n1 % i == 0 || n2 % i == 0)
                {
                    if (n1 % i == 0)
                    {
                        n1 = n1 / i;
                    }
                    if (n2 % i == 0)
                    {
                        n2 = n2 / i;
                    }
                    mmc = mmc * i;
                }
                else
                {
                    i++;
                }
            }

            return mmc;
        }

        static void Main(string[] args)
        {
            int op;
            do
            {
                Console.WriteLine("Calcular MMC - Digite 1");
                Console.WriteLine("Calcular MDC - Digite 2");
                Console.WriteLine("Sair do Programa - Digite 3");
                op = int.Parse(Console.ReadLine());


                if (op == 1)
                {
                    Console.WriteLine("Digite o primeiro numero :");
                    int n1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o segundo numero :");
                    int n2 = int.Parse(Console.ReadLine());
                   Console.WriteLine(MMC(n1 , n2));
                }

                else if(op == 2)
                {
                    
                }

                else if (op == 3)
                {
                    Console.WriteLine("Saindo");
                }
                else
                {
                    Console.WriteLine("Digite uma opção valida");
                }


            } while (op != 3);



        }
    }
}
