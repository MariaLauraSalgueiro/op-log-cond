/*Ref. (10 pontos)
3 - Escreva um programa que receba três números inteiros e mostre eles em ordem
crescente.
Nome: Maria Laura Salgueiro de Azevedo
*/
public class Exercicio3
{

    public static void Executar()
    {
        int numeroUm;
        int numeroDois;
        int numeroTres;
        int auxiliar;



        Console.WriteLine("Digite primeiro número");
        numeroUm = int.Parse(Console.ReadLine()!);

        Console.WriteLine("Digite o segundo número");
        numeroDois = int.Parse(Console.ReadLine()!);

        Console.WriteLine("Digite o terceiro numero");
        numeroTres = int.Parse(Console.ReadLine()!);

        if (numeroUm > numeroDois)
        {
            auxiliar = numeroUm;
            numeroUm = numeroDois;
            numeroDois = auxiliar;
        }
        if (numeroDois > numeroTres)
        {
            auxiliar = numeroDois;
            numeroDois = numeroTres;
            numeroTres = auxiliar;
        }    
        if (numeroUm > numeroDois)
        {
            auxiliar = numeroUm;
            numeroUm = numeroDois;
            numeroDois = auxiliar;
        }
        Console.WriteLine($"Os números em ordem crescente são: {numeroUm}, {numeroDois}, {numeroTres}");
        




    }
}
