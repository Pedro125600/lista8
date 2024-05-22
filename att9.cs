namespace att9
{
    internal class Program
    {
        static int[] ObterMaiorMenor(int[] v)
        {
            int[] MaiorMenor = new int[2];
            MaiorMenor[0] = v[0];
            MaiorMenor[1] = v[0];
            
            for(int i = 0;i < v.Length;i++)
            {
                if (MaiorMenor[0] < v[i])
                {
                    MaiorMenor[0] = v[i];
                }

                if (MaiorMenor[1] > v[i])
                {
                    MaiorMenor[1] = v[i];
                }
            }

            return MaiorMenor;
        }

        static void Main(string[] args)
        {
            int[] vet = new int[10];

            for(int i = 0; i < 10; i++)
            {
                Random r = new Random();
                vet[i] = r.Next(100);
                Console.Write(vet[i] + " ");
            }

            Console.WriteLine("");

            int[] MaiorMenor = ObterMaiorMenor(vet);
            Console.WriteLine("O maior elemento do vetor é: " + MaiorMenor[0]);
            Console.WriteLine("O menor elemento do vetor é: " + MaiorMenor[1]);
        }
    }
}
