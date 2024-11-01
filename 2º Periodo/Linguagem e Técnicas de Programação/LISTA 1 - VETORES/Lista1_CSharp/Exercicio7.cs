using Biblioteca_Array;
using System;

public class Ex7
{

    static void Main()
    {
        Console.WriteLine("digite a quantidades de numeros vetor 1");
        int n1 = int.Parse(Console.ReadLine());

        Console.WriteLine("digite a quantidades de numeros vetor 2");
        int n2 = int.Parse(Console.ReadLine());

        if (n1 != n2)
        {
            Console.Write("as duas devem ter o mesmo tamanho ");
            return;
        }

        int[] array1 = new int[n1];
        int[] array2 = new int[n2];

        ArrayFunctions.GerarArray(array1);
        ArrayFunctions.GerarArray(array2);

        int[] result = new int[array1.Length];

        Console.WriteLine("Mostrando vetor 1");
        ArrayFunctions.mostraVetor(array1);
        Console.WriteLine("\n Mostrando vetor 2");
        ArrayFunctions.mostraVetor(array2);

        for (int i = 0; i < array1.Length; i++)
        {
            result[i] = array1[i] * array2[i];
        }
        Console.WriteLine("O resultado da multiplicação é: " + string.Join(", ", result));
    }
}