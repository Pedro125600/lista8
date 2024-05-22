namespace att5
{
    internal class Program
    {

        static int Vogais(char[] v)
        {
            int c = 0;
            for (int i = 0; i < 5; i++)
            {
                if (v[i] == 'a' || v[i] == 'e' || v[i] == 'i' || v[i] == 'o' || v[i] == 'u')
                {
                    c++;
                }
            }
            return c;
        }

        static void Main(string[] args)
        {
            char[] vet = new char[5];
            
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Escreva uma letra para a {i + 1} posição no vetor:");
                vet[i] = char.Parse( Console.ReadLine() );

            }

            Console.WriteLine($"O numero de vogais e {Vogais(vet)} ");


        }
    }
}
