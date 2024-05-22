namespace att3
{
    internal class Program
    {
        static int MMC(int n1, int n2)
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

        static int MDC(int n1, int n2)
        {
            while (n2 != 0)
            {
                int temp = n2;
                n2 = n1 % n2;
                n1 = temp;
            }
            return n1;
        }

        static int MDC(int n1, int n2, int n3)
        {
            int mdc12 = MDC(n1, n2);

            int mdc123 = MDC(mdc12, n3);

            return mdc123;
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
                    Console.WriteLine(MMC(n1, n2));
                }

                else if (op == 2)
                {
                    Console.WriteLine("Digite o primeiro numero :");
                    int n1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o segundo numero :");
                    int n2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o terceiro numero :");
                    int n3 = int.Parse(Console.ReadLine());
                    Console.WriteLine(MDC(n1, n2,n3));
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
