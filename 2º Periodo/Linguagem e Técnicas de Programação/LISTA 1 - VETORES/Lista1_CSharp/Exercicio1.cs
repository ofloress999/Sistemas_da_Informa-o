using System; //Adiciona a biblioteca System
using Biblioteca_Array;


namespace ex1;
public class Exercicio_1
{
    private static void Main()
    {
        // Perguntar ao usuário quantos elementos o array deve ter
        Console.Write("Quantos elementos tera no seu array? ");
        int number = int.Parse(Console.ReadLine());

        // Chamar a função GerarArray, passando o número de elementos
        int[] array = ArrayFunctions.GerarArray(number);

        // Exibir o array gerado
        Console.WriteLine("Array gerado com números aleatórios:");
        foreach (var item in array)
        {
            Console.Write(item + ", ");
        }

        // Exibe a soma de todos elementos do array
        int soma = ArrayFunctions.SomarArray(array);
        Console.WriteLine($"\n A soma dos elementos do array é: {soma}");
       
    }

}