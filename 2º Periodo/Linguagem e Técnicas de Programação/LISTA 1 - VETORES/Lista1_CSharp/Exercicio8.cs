using Biblioteca_Array; 
using System;

class Ex8
{
    static void Main()
    {
        Console.WriteLine("Digite a quantidade de números no array:");
        int n = int.Parse(Console.ReadLine());

       
        int[] array = ArrayFunctions.GerarArray(n);
        ArrayFunctions.mostraVetor(array); 

        int tamanhoArray = array.Length;
        Console.WriteLine($"\nTamanho do array: {tamanhoArray}");

        Console.WriteLine("Invertendo o vetor...");
        ArrayFunctions.InverterVetor(array); 

        ArrayFunctions.mostraVetor(array); 
    }
}
