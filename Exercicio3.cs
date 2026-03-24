/*Ref. (10 pontos)
3 - Escreva um programa que receba três números inteiros e mostre eles em ordem
crescente.
Nome: Maria Laura Salgueiro de Azevedo
*/
public class Exercicio3
{

    public static void Executar()
    {
        int n1;
        int n2;
        int n3;
        int maior = 0;
        int medio = 0;
        int menor = 0;

        Console.WriteLine("Digite primeiro número");
        n1 = int.Parse(Console.ReadLine()!);

        Console.WriteLine("Digite o segundo número");
        n2 = int.Parse(Console.ReadLine()!);

        Console.WriteLine("Digite o terceiro numero");
        n3 = int.Parse(Console.ReadLine()!);

        if((n1 > n2) && (n1 > n3))
        {
            maior = n1;

            if ((n2 > n3))
            {
                medio = n2;
                menor = n3;

            }

            else
            {
                medio = n3;
                menor = n2;
            }
        }

        Console.WriteLine($"Os números em ordem crscente são: {menor}, {medio}, {maior}");
        
        




    }
}
