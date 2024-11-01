using System;

public class Ex6
{
    static void Main()
    {
        Random random = new Random();

        Console.WriteLine("digite a quantidades de numeros sorteados");
        int n = int.Parse(Console.ReadLine());

        int[] vetor = new int[n];

        for (int i = 0; i < n; i++)
        {
            vetor[i] = random.Next(1, 101);
        }
        Console.WriteLine("qual numero voce acha q ta sorteado");
        int numbuscar = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            if (vetor[i] == numbuscar)
            {
                Console.WriteLine($"o numero {numbuscar} esta na posicao {i}");
            }
        }
        Console.WriteLine($"o numero {numbuscar} nao foi sorteado ");
    }
}