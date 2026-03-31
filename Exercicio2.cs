/* Ref (5 pontos)
2 – Faça um programa que verifique se uma letra digitada é vogal ou consoante.
Nome: Maria Laura Salgueiro de Azevedo
*/



public class Exercicio2
{
    public static void Executar()
    {
        Console.WriteLine("Digite a letra");
        Console.WriteLine();

        string letra = Console.ReadLine()!.ToLower();

        if (letra == "a" || letra == "e" || letra == "i" || letra == "o" || letra == "u")
        {
            Console.WriteLine("Está letra é uma vogal");

        }
        else
        {
            Console.WriteLine("Está letra é uma consoante");
        }

    }
}
