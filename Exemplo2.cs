using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/*Ref (5 pontos)
1 - Faça um programa que calcule e apresente o valor do volume de uma lata,
sabendo que PI é um valor constante de 3.14159, o programa deve pedir os valores
de RAIO e ALTURA, utilize a fórmula VOLUME = PI * RAIO² * ALTURA.
Nome:
*/

namespace op_log_cond
{
    public class Exemplo2
    {
        public static void Executar()
        {
            double nota;
            double frequencia;

            Console.WriteLine("Digite a nota do aluno:");
            nota = double.Parse(Console.ReadLine()!);

            Console.WriteLine();

            Console.WriteLine("Digite a frequência do aluno: ");
            frequencia = double.Parse(Console.ReadLine()!);

            if (nota >= 7)
            {
                if (frequencia >= 75)
                {
                    Console.WriteLine("Aluno aprovado!");
                }
                else
                {
                    Console.WriteLine("Aluno reprovado por falta!");
                }

            }
        }
    }
}