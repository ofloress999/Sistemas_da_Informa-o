using System;
using biblioteca_Mat;
using Biblioteca_Array;

    public class Exercicio3
    {
      public static void Main()
      {
        Console.Write("Escolha a quantidade de elementos do seu Array: ");
        int Number = int.Parse(Console.ReadLine());

        double[] MyArray = ArrayFunctions.GerarDoubleArray(Number);

        foreach (double item in MyArray)
        {
            Console.WriteLine($"{item:F2}");
        }

        double MenorElemento = ArrayFunctions.MenorElementoDouble(MyArray);
        Console.WriteLine($"\n O menor elemento do array é: {MenorElemento:F2}");

    }
}


