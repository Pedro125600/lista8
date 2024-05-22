namespace att11
{
    internal class Program
    {
        static void ConverterSegundos(int totalSegundos, out int hora, out int min, out int seg)
        {
            hora = totalSegundos / 3600; 
            min = (totalSegundos % 3600) / 60; 
            seg = totalSegundos % 60; 
        }
        static void Main(string[] args)
        {
            
            Console.Write("Digite a quantidade total de segundos: ");
            int totalSegundos = int.Parse(Console.ReadLine());

         
            ConverterSegundos(totalSegundos, out int hora, out int min, out int seg);

            
            Console.WriteLine($"O total de {totalSegundos} segundos é equivalente a {hora}:{min}:{seg}.");

            Console.ReadLine(); 
        }

       
    
    }
}
