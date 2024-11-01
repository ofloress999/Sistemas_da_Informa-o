using System;
using Biblioteca_Array;
using biblioteca_Mat;

namespace ex2
{
    public class Exercicio_2
    {
        public static void Main ()
        {
            Console.Write("Escolha a quantidade de elementos do seu Array: ");
            int Number = int.Parse(Console.ReadLine());

            double[] MyArray = ArrayFunctions.GerarDoubleArray(Number);
            
            foreach(double item in MyArray)
            {
                Console.WriteLine($"{item:F2}");
            }

            double MaiorElemento = ArrayFunctions.MaiorElementDouble(MyArray);
            Console.WriteLine($"\n O maior elemento do array é: {MaiorElemento:F2}");
                        

        }

    }
}
