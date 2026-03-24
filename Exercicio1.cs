/*Ref (5 pontos)
1 - Faça um programa que calcule e apresente o valor do volume de uma lata,
sabendo que PI é um valor constante de 3.14159, o programa deve pedir os valores
de RAIO e ALTURA, utilize a fórmula VOLUME = PI * RAIO² * ALTURA.
Nome: Maria Laura Salgueiro de Azevedo
*/

public class Exercicio1
{
    public static void Executar()
    {
        double pi = 3.14159;
        double raio;
        double altura;
        double volume;

        Console.WriteLine("Digite a altura da lata");
        altura = double.Parse(Console.ReadLine()!);

        Console.WriteLine();

        Console.WriteLine("Digite o raio da lata");
        raio = double.Parse(Console.ReadLine()!);

        volume = pi * raio * raio * altura;

        Console.WriteLine(volume);



    }

}










