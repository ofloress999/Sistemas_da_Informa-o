using System;
using biblioteca_Mat;
using Biblioteca_Array;

public class Exercicio5
{
    public static void Main()
    {

        char[] dna = new char[50];
        int n;

        Console.WriteLine("Digite o número de bases (máximo 50):");
        n = int.Parse(Console.ReadLine());

        if (n > 50 || n <= 0)
        {
            Console.WriteLine("Número de bases deve estar entre 1 e 50.");
            return;
        }

        Console.WriteLine("Digite a sequência de DNA (A, T, C, G):");
        for (int i = 0; i < n; i++)
        {
            char baseDNA = Console.ReadKey().KeyChar;
            Console.WriteLine();


            if (baseDNA == 'A' || baseDNA == 'T' || baseDNA == 'C' || baseDNA == 'G')
            {
                dna[i] = baseDNA;
            }
            else
            {
                Console.WriteLine("Base inválida. Use A, T, C ou G.");
                i--;
            }
        }

        char[] complemento = GeraComplementar(dna, n);
        Console.WriteLine("Sequência complementar: " + new string(complemento));
    }

    static char[] GeraComplementar(char[] dna, int n)
    {
        char[] complemento = new char[n];
        for (int i = 0; i < n; i++)
        {
            switch (dna[i])
            {
                case 'A':
                    complemento[i] = 'T';
                    break;
                case 'T':
                    complemento[i] = 'A';
                    break;
                case 'C':
                    complemento[i] = 'G';
                    break;
                case 'G':
                    complemento[i] = 'C';
                    break;
            }
        }
        return complemento;
    }
}


