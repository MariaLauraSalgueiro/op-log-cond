/*Ref. (5 pontos)
9 - Escreva um programa que leia um número e verifique se ele é positivo,
negativo ou zero.
Nome:
*/
    public class Exercicio9
    {
        public static void Executar()
        {
            Console.WriteLine("Digite um número:");
            double numero = double.Parse(Console.ReadLine()!);

            if (numero > 0)
            {
                Console.WriteLine("O número é positivo.");
            }
            else if (numero < 0)
            {
                Console.WriteLine("O número é negativo.");
            }
            else
            {
                Console.WriteLine("O número é zero.");
            }
        }
    }