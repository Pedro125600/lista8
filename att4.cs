namespace att4
{
    internal class Program
    {
        static void CalcularP(int n1, int n2, int n3)
        {

            
                double mediaPonderada = (n1 * 5 + n2 * 3 + n3 * 2) / (double)10;
                Console.WriteLine("A média ponderada é:" + mediaPonderada);
         

        }
        static void CalcularA(int n1, int n2, int n3)
        {
            
                double mediaAritmetica = (n1 + n2 + n3) / 3.0;
                Console.WriteLine("A média aritmética é:" + mediaAritmetica);
           

        }
        public static void Main(string[] args)
        {
            Console.Write("Escreva o Primeiro valor :");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Escreva o Segundo valor :");
            int n2 = int.Parse(Console.ReadLine());
            Console.Write("Escreva o terceiro valor :");
            int n3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Escolha uma opção \n A:calcular e escrever a média aritmética dos valores \n P: imprimir a média ponderada, usando os seguintes pesos: 5, 3 e 2");
             char op = char.Parse(Console.ReadLine());

            if(op == 'A')
            {
                CalcularA(n1, n2, n3);
            }
               
            else if(op == 'P')
            {
                CalcularP(n1, n2, n3);
            }
            else
            {
                Console.WriteLine("opção invalida");
            }
           

        }


    }
}
