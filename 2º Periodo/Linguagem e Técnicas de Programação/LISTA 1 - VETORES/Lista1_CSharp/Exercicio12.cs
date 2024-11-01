using System;

public class Ex12
{
    static void Main()
    {
        string[] notasInput = Console.ReadLine().Split(' ');
        double[] notas = new double[5];

        for (int i = 0; i < 5; i++)
        {
            notas[i] = Convert.ToDouble(notasInput[i]);
        }

        double maiorNota = notas[0];
        double menorNota = notas[0];
        double somaFinal = 0;

        for (int i = 0; i < 5; i++)
        {
            if (notas[i] > maiorNota)
                maiorNota = notas[i];
            if (notas[i] < menorNota)
                menorNota = notas[i];
            somaFinal += notas[i];
        }

        somaFinal -= maiorNota;
        somaFinal -= menorNota;

        int contagemMaior = 0, contagemMenor = 0;

        for (int i = 0; i < 5; i++)
        {
            if (notas[i] == maiorNota) contagemMaior++;
            if (notas[i] == menorNota) contagemMenor++;
        }

        if (contagemMaior > 1) somaFinal += maiorNota;
        if (contagemMenor > 1) somaFinal += menorNota;

        Console.WriteLine($"{somaFinal:F1}");
    }
}