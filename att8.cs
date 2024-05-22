namespace att8
{
    internal class Program
    {
        static double CalcularSoma(int n)
        {
            double s = 0;

            for (int i = 1; i <= n; i++)
            {
                s += i * i + 1 / i + 3; 
            }

            return s ;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor inteiro positivo para n:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"O valor da soma S e : {CalcularSoma(n)}");

        }
    }
}
