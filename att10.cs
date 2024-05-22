namespace att10
{
    internal class Program
    {
        static int[] LerValoresDoVetor(string nomeDisciplina)
        {
            int[] vetor = new int[10];
            Console.WriteLine($"Digite os números de matrícula dos alunos matriculados em {nomeDisciplina}:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Matrícula {i + 1}: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }
            return vetor;
        }

        static int[] CalcularIntersecao(int[] vetor1, int[] vetor2)
        {
            int[] v = new int[10];
            
            for(int i = 0;i < 10;i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (vetor1[i] == vetor2[j])
                    {
                        v[i] = vetor1[i];
                    }
                }
            }

            return v;
        }

        static void Main(string[] args)
        {
            int[] matriculasAlgoritmos = LerValoresDoVetor("Algoritmos e Técnicas de Programação");
            int[] matriculasDIW = LerValoresDoVetor("Desenvolvimento de Interfaces Web (DIW)");
            int[] intersecao = CalcularIntersecao(matriculasAlgoritmos, matriculasDIW);

            for(int i = 0; i < intersecao.Length ; i++)
            {
                Console.WriteLine($"\nmatricula {intersecao[i]}");
                if (intersecao[i] > 0)
                {

                    Console.WriteLine("Aluno matriculado simultaneamente nas duas disciplinas:");
                   

                }
                else
                {
                    Console.WriteLine("Não existem alunos matriculados simultaneamente nas duas disciplinas.");
                }
            }
        }
    }
}
