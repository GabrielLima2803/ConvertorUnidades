using System;

namespace Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 - Deseja Converter de Celsius para Fahrenheit");
            Console.WriteLine("2 - Deseja Converter de Quilômetros para Milhas");
            Console.WriteLine("3 - Deseja Converter de Metros Cúbicos para Litros");
            int converter = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número que deseja converter ");
            int num = int.Parse(Console.ReadLine());

            double resultado = 0;

            if (converter == 1)
            {
                resultado = (num * 9.0 / 5) + 32;
                Console.WriteLine($"Resultado: {resultado} Fahrenheit");
            }
            else if (converter == 2)
            {
                resultado = num / 1.609;
                Console.WriteLine($"Resultado: {resultado} Milhas");
            }
            else if (converter == 3)
            {
                resultado = num / 1000;
                Console.WriteLine($"Resultado: {resultado} Litros");
            }
            else
            {
                Console.WriteLine("Opção não existe");
            }
            Console.ReadLine();
        }
    }
}
