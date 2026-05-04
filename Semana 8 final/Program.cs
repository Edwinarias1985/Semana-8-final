namespace Semana_8_final
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* Algoritmo para el promedio de notas de un curso */

            // 1. Estilo consola
            Console.Title = "Algoritmo de Promedio Final";
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            // 2. Variables: se usa el double para permitir decimales como 3.5
            double nota1 = -1, nota2 = -1, nota3 = -1, resultado;

            // 3. Validación de Nota 1 (30%)
            while (nota1 < 0 || nota1 > 5)
            {
                Console.WriteLine("Ingrese la nota 1, 30%: ");
                nota1 = double.Parse(Console.ReadLine());
                if (nota1 < 0 || nota1 > 5)
                {
                    Console.WriteLine("Nota errada debe ser entre 0 y 5.");
                }
            }

            // 4. Validación de Nota 2 (30%)
            while (nota2 < 0 || nota2 > 5)
            {
                Console.WriteLine("Ingrese la nota 2, 30%: ");
                nota2 = double.Parse(Console.ReadLine());
                if (nota2 < 0 || nota2 > 5)
                {
                    Console.WriteLine("Nota errada debe ser entre 0 y 5.");
                }
            }

            // 5. Validación de Nota 3 (40%)
            while (nota3 < 0 || nota3 > 5)
            {
                Console.WriteLine("Ingrese la nota, 3 40%: ");
                nota3 = double.Parse(Console.ReadLine());
                if (nota3 < 0 || nota3 > 5)
                {
                    Console.WriteLine("Nota errada debe ser entre 0 y 5.");
                }
            }

            // 6. Análisis y resultado
            resultado = (nota1 * 0.30) + (nota2 * 0.30) + (nota3 * 0.40);

            Console.WriteLine("El promedio final es: " + resultado);

            Console.ReadKey();



        }
    }
}
