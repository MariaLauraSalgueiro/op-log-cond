/*Ref. (15 pontos)
7 - Para doar sangue é necessário ter entre 18 e 67 anos e possuir mais de 60 kg. 
Faça um aplicativo que pergunte a idade de uma pessoa e seu peso e diga se ela pode doar sangue ou não; caso não possa, diga o(s) motivo(s).
Atividades
Nome:Maria Laura Salgueiro de Azevedo
*/
public class Exercicio7
{

    public static void Executar()
        {
            Console.WriteLine("Qual é a sua idade?");
            double idade = double.Parse(Console.ReadLine()!);
            Console.WriteLine("Qual é o seu peso?");
            double peso = double.Parse(Console.ReadLine()!);
            if(idade >= 18 && idade <= 67 && peso > 60)
            {
                Console.WriteLine("Você pode doar sangue");
            }
            else
            {
                if(idade < 18)
                {
                    Console.WriteLine("Você não pode doar sangue porque é menor de idade");
                }
                else if(idade > 67)
                {
                    Console.WriteLine("Você não pode doar sangue porque é maior de idade");
                }
                if(peso <= 60)
                {
                    Console.WriteLine("Você não pode doar sangue porque pesa menos de 60 kg");
                }
            }
        }
}  

