namespace att12
{
    internal class Program
    {
        static int[] EncontrarMaiorElemento(int[,] matriz)
        {
            int[] resultado = new int[3];
            int maior = matriz[0, 0];
            int lin = 0;
            int col = 0;


            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (matriz[i, j] > maior)
                    {
                        maior = matriz[i, j];
                        lin = i;
                        col = j;
                    }
                }
            }

            resultado[0] = maior;
            resultado[1] = lin;
            resultado[2] = col;

            return resultado;
        }

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
        static void Main(string[] args)
        {
            Console.WriteLine("De o valor de n");
            int n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n,n];
            Random r = new Random(); 
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    
                    matriz[i, j] = r.Next(100);
                }
            }

            ExibirMatriz(matriz);

            int[] resultado = EncontrarMaiorElemento(matriz);

            int k = resultado[0];
            int lin = resultado[1];
            int col = resultado[2];

            Console.WriteLine($"O maior elemento é : {k}, na linha {lin} e coluna {col}.");

            Console.ReadLine(); 
        }

      
    }
}
