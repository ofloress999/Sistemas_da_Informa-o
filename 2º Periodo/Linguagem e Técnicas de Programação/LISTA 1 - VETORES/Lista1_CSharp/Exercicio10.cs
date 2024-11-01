using Biblioteca_Array;
using System;

public class Ex10
{

    static void geravetordado(int[] vetor)
    {
        Random rnd = new Random();
        for (int i = 0; i < vetor.Length; i++)
            vetor[i] = rnd.Next(1, 7);
    }
    static int[] ContarOcorrencias(int[] vetor)
    {
        int[] contagem = new int[6];

        foreach (int resultado in vetor)
        {
            contagem[resultado - 1]++;
        }

        return contagem;
    }

    static void ImprimirOcorrencias(int[] contagem)
    {
        for (int face = 1; face <= 6; face++)
        {
            Console.WriteLine($"Face {face}: {contagem[face - 1]} ocorrências");
        }
    }
    static void Main()
    {
        Console.WriteLine("Digite a quantidades de vezes que foi lançado");
        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n];

        geravetordado(array);

        int[] ocorrencias = ContarOcorrencias(array);

        ImprimirOcorrencias(ocorrencias);

    }
}