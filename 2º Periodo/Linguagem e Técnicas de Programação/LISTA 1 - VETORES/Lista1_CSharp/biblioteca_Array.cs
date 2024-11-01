using System;

namespace Biblioteca_Array
{
    public static class ArrayFunctions
    {
        public static int[] GerarArray(int number)
        {
            int[] array = new int[number];  // Cria o array com o tamanho fornecido
            Random random = new Random();   // Instância da classe Random para gerar números aleatórios
            for (int i = 0; i < number; i++)// Preenche o array com números aleatórios
            {
                array[i] = random.Next(1, 101);  // Gera números aleatórios entre 1 e 100
            }
            return array;// Retorna o array gerado
        }

        // Soma todos elemetos de um array
        public static int SomarArray(int[] array)
        {
            int soma = 0;
            foreach(var item in array)
            {
                soma += item;
            }
            return soma;
        }

        // Mostra vetor
        public static void mostraVetor(int[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write($"|{vetor[i]}");
            }
        }

        // Gera um array com elementos double
        public static double[] GerarDoubleArray(int number)
        {
            double[] array = new double[number];
            Random random = new Random();

            for (int i = 0; i < number; i++)
            {
                array[i] = random.NextDouble() * 99;  // Gera números aleatórios entre 1 e 100
            }
            return array;
        }

        // Mostra o maior elemento do array
        public static double MaiorElementDouble(double[] array) { 
            if (array.Length == 0)
            {
                Console.Write("O array não pode estar vazio!");
            }

            double maior = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > maior)
                {
                    maior = array[i];
                }
            }
            return maior;
        }

        // Mostra o menor elemento do array
        // Mostra o menor elemento do array
        public static double MenorElementoDouble(double[] array)
        {
            if (array.Length == 0)
            {
                Console.WriteLine("O array não pode estar vazio!");
                return double.NaN; // Retorna NaN para indicar valor inválido
            }

            double menor = array[0]; // Inicializa com o primeiro elemento
            for (int i = 1; i < array.Length; i++) // Começa do índice 1
            {
                if (array[i] < menor)
                {
                    menor = array[i];
                }
            }

            return menor; // Retorna o menor valor encontrado
        }

        // Gera um vetor com aleatorio com os seguintes "char" = A, T, C ,G
        public static char[] GerarVetorDNA(int tamanho)
        {
            char[] basesDNA = { 'A', 'T', 'C', 'G' }; // Letras permitidas no vetor DNA: A, T, C, G
            char[] vetorDNA = new char[tamanho];// Cria um vetor de caracteres do tamanho especificado
            Random random = new Random(); // Instancia o gerador de números aleatórios
            for (int i = 0; i < tamanho; i++) // Preenche o vetor com bases aleatórias
            {
                // Escolhe aleatoriamente uma base (A, T, C ou G) do array basesDNA
                vetorDNA[i] = basesDNA[random.Next(basesDNA.Length)]; 
            }
            return vetorDNA;  // Retorna o vetor gerado com as bases de DNA
        }

        public static void InverterVetor(int[] vetor)
        {
            for (int i = 0; i < vetor.Length / 2; i++)
            {

                int temp = vetor[i];
                vetor[i] = vetor[vetor.Length - 1 - i];
                vetor[vetor.Length - 1 - i] = temp;
            }


        }
    }
}
