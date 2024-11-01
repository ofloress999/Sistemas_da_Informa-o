using System;
using biblioteca_Mat;
using Biblioteca_Array;

public class Exercicio4
{
    public static void Main()
    {
        Console.Write("Escolha a quantia de elementos do array: ");
        int escolha = int.Parse(Console.ReadLine());

        int[] MyArray = ArrayFunctions.GerarArray(escolha);
        foreach (int item in MyArray)
        {
            Console.Write(item + " ");
        }
        

        int valoresImpares = 0;

        for(int i = 0; i < MyArray.Length; i++)
        {
            if(MyArray[i] % 2 != 0)
            {
                valoresImpares++;
            }
        }
        Console.Write("\n " + valoresImpares);

    }
}

