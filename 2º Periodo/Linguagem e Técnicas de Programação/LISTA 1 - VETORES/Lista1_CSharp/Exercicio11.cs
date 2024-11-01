using System;


public class Ex11
{
    static void Main()
    {
        Console.WriteLine("Digite a mensagem:");
        string mensagemCodificada = Console.ReadLine();
        string mensagemDecodificada = "";

        for (int i = 0; i < mensagemCodificada.Length; i++)
        {
            if (mensagemCodificada[i] == 'p')
            {
                if (i + 1 < mensagemCodificada.Length)
                {
                    mensagemDecodificada += mensagemCodificada[i + 1];
                }
                i++;
            }
            else
            {
                mensagemDecodificada += mensagemCodificada[i];
            }
        }
        Console.WriteLine("Mensagem decodificada: " + mensagemDecodificada);
    }
}