/*Ref (15 pontos)
5 - As maçãs custam R$ 0,30 cada se forem compradas menos do que uma dúzia,
e R$ 0,25 se forem compradas pelo menos doze. Escreva um programa que leia o número de maçãs compradas, calcule e escreva o valor total da compra.
Nome:
*/
namespace op_log_cond
{
    public class Exercicio5

    {
        
        public static void Executar()
        {

    
        double maca;
        double macaValor;
        double totalDeValor;

        Console.WriteLine("Quantas maças foram compradas?");
        maca = double.Parse(Console.ReadLine()!);

        if (maca < 12)
        {
            macaValor = 0.30;
        }

        else
        {
            macaValor = 0.25;

        }
        totalDeValor = maca*macaValor;
        Console.WriteLine($"O total da compra é: {totalDeValor}");
        

        }
    }
}