/*Ref. (5 pontos)
10 - Escreva um programa que leia um número e verifique se ele é par ou ímpar.
Nome:
*/
    public class Exercicio10
    {
        public static void Executar()
        {
            Console.WriteLine("Digite um número:");
            int numero = int.Parse(Console.ReadLine()!);

            if (numero % 2 == 0)
            {
                Console.WriteLine("O número é par.");
            }
            else
            {
                Console.WriteLine("O número é ímpar.");
            }
        }
    }
