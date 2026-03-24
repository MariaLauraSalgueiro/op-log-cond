
/*Ref (15 pontos)
4 – Ler valor de nota de N1 e N2, calcular a média e escrever a nota correspondente, tal que 0 é a menor nota e 10 a maior, e imprimir o conceito equivalente
(A, B, C, D ou E), conforme a seguinte tabela:
A - nota >= 8,5 e nota <= 10
B - nota >= 7 e nota < 8,5
C - nota >= 5 e nota < 7
D - nota >= 3 e nota < 5
E - nota < 3
Nome: Maria Laura Salgueiro de Azevedo
*/
public class Exercício4
{
    public static void Executar()
    {
        double n1;
        double n2;
        double media;
        double notaA = 0;
        double notaB = 0;
        double notaC = 0;
        double notaD = 0;
        double notaE = 0;
        double notafinal;


        Console.WriteLine("Digite a nota do aluno");
        n1 = double.Parse(Console.ReadLine()!);

        Console.WriteLine("Digite a nota do aluno");
        n2 = double.Parse(Console.ReadLine()!);
        
        media = (n1 + n2)/2;

        if(media >= 8.5 && media <= 10)
        {
           notafinal = notaA;
           Console.WriteLine($"A nota corresponde é: {media}, logo A");
        }

        else if(media >= 7 && media <= 8.5)
        {
            notafinal = notaB;
            Console.WriteLine($"A nota corresponde é: {media}, logo B");

        }
        else if(media >= 5 && media <= 7)
        {
            notafinal = notaC;
            Console.WriteLine($"A nota corresponde é: {media}, logo C");

        }

        else if(media >= 3 && media <= 5)
        {
            notafinal = notaD;
            Console.WriteLine($"A nota corresponde é: {media}, logo D");

        }
        else if(media < 3)
        {
            notafinal = notaE;
            Console.WriteLine($"A nota corresponde é: {media}, logo E");
        }

       






    }


}
        

