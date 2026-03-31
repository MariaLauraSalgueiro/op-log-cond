/*Ref. (10 pontos)
8 - Crie um programa que faça 5 perguntas para uma pessoa sobre um crime.
As perguntas são:
"Telefonou para a vítima?"
"Esteve no local do crime?"
"Mora perto da vítima?"
"Devia para a vítima?"
"Já trabalhou com a vítima?"
O programa deve, no final, emitir uma classificação sobre a participação da pessoa no crime. Se a pessoa responder positivamente a 2 questões, ela deve ser
classificada/exibida como "Suspeita", entre 3 e 4 como "Cúmplice" e 5 como "Assassino". Caso contrário, ela será classificada como "Inocente".
Aluno:
*/
public class Exercicio8
 {
    Console.WriteLine("Responda as seguintes perguntas com sim ou não:");

    Console.WriteLine("Telefonou para a vítima?");
    string resposta1 = (Console.ReadLine()!);

    Console.WriteLine("Esteve no local do crime?");
    string resposta2 = (Console.ReadLine()!);

    Console.WriteLine("Mora perto da vítima?");
    string resposta3 = (Console.ReadLine()!);

    Console.WriteLine("Devia para a vítima?");
    string resposta4 = (Console.ReadLine()!);

    Console.WriteLine("Já trabalhou com a vítima?");
    string resposta5 = (Console.ReadLine()!);

    int contagem = 0;

    if(resposta1.ToLower() == "sim")
    {
        contagem++;
    }
    if(resposta2.ToLower() == "sim")
    {
        contagem++;
    }
    if(resposta3.ToLower() == "sim")
    {
        contagem++;
    }
    if(resposta4.ToLower() == "sim")
    {
        contagem++;
    }
    if(resposta5.ToLower() == "sim")
    {
        contagem++;
    }

    if(contagem == 2)
    {
        Console.WriteLine("Suspeita");
    }
    else if(contagem == 3 || contagem == 4)
    {
        Console.WriteLine("Cúmplice");
    }
    else if(contagem == 5)
    {
        Console.WriteLine("Assassino");
    }
    else
    {
        Console.WriteLine("Inocente");
    }
 }