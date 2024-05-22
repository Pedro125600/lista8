namespace att6
{
    internal class Program
    {
        static void ExibirMatriz(int[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i, j] + "  ");
                }
                Console.WriteLine("\n");
            }
        }
         static void MultiplicarEscalar(int[,] matriz, int n)
        {

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] *= n;
                }
            }
        }

        public static void Main(string[] args)
        {
            int[,] matriz = new int[3,3];

            Random r = new Random();

            for(int i = 0; i < matriz.GetLength(0);i++)
            {
                for(int j = 0;j < matriz.GetLength(1);j++)
                {
                    matriz[i, j] = r.Next(100);
                }
            }

            Console.WriteLine("Matriz original:");
            ExibirMatriz(matriz);

            Console.WriteLine("De o valor de N");
            int n = int.Parse(Console.ReadLine());


            MultiplicarEscalar(matriz, n);

            Console.WriteLine("\nMatriz após multiplicação escalar:");
            ExibirMatriz(matriz);
        }

        
    }
}

