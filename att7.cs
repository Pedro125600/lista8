namespace att7
{
    internal class Program
    {
    
            static double CalcularSoma(int n)
            {
                double s = 1;

                for (int i = 2; i <= n; i++)
                {
                   s += 1 / i;
                }

                return s;
            }

        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor inteiro positivo para n:");
                int n = int.Parse(Console.ReadLine());

                    Console.WriteLine($"O valor da soma S e : {CalcularSoma(n)}" );
                
        }
    }
}
