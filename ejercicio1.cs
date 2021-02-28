using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = new double[4];
            Console.WriteLine("Escriba cuatro números: ");
            for (int i=0; i<4; i++)
            {
                numbers[i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Números digitados: {numbers[0]}, {numbers[1]}, {numbers[2]}, {numbers[3]}.");
            Console.WriteLine($"Media aritmética: {(numbers[0]+ numbers[1]+ numbers[2]+ numbers[3])/4}");
        }
    }
}
