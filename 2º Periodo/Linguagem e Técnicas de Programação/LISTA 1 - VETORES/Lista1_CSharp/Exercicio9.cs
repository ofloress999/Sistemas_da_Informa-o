using Biblioteca_Array;
using System;

public class Ex9
{
    static void Main()
    {
        Console.WriteLine("Digite a quantidade de números no array:");
        int n = int.Parse(Console.ReadLine());

        int[] array = ArrayFunctions.GerarArray(n);
        ArrayFunctions.mostraVetor(array);

        Console.WriteLine("\nDigite um valor para verificar quantas vezes ele aparece no array:");
        int valor = int.Parse(Console.ReadLine());

        int cont = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == valor)
            {
                cont++;
            }
        }

        Console.WriteLine($"O valor {valor} aparece {cont} vez(es) no array.");
    }
}
