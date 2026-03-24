/*Ref. (10 pontos)
6 - Um programa deve ler três ângulos e verificar qual é o tipo de triângulo formado. Primeiro, é necessário conferir se a soma dos três ângulos é igual a 180°,
pois só assim eles formam um triângulo. Depois, se um dos ângulos for igual a 90°, o triângulo é retângulo. Se um dos ângulos for maior que 90°, ele é obtusângulo.
Caso contrário, se os três forem menores que 90°, o triângulo é acutângulo.
Nome:Maria Laura Salgueiro de Azevedo
*/

public class Exercicio6
    {
        public static void Executar()
        {
            double angulo1 = 0;
            double angulo2 = 0;
            double angulo3 = 0;
            
            Console.WriteLine("Insira o primeiro angulo");
            angulo1 = double.Parse(Console.ReadLine()!);

            Console.WriteLine("Insira o segundo angulo");
            angulo2 = double.Parse(Console.ReadLine()!);

            Console.WriteLine("Insira o terceiro angulo");
            angulo3 = double.Parse(Console.ReadLine()!);
           
           double somaDosAngulos;
           somaDosAngulos = angulo1 + angulo2 + angulo3;
           
              if(somaDosAngulos == 180)
              {
                 if(angulo1 == 90 || angulo2 == 90 || angulo3 == 90)
                 {
                      Console.WriteLine("O triângulo é retângulo");
                 }
                 else if(angulo1 > 90 || angulo2 > 90 || angulo3 > 90)
                 {
                      Console.WriteLine("O triângulo é obtusângulo");
                 }
                 else
                 {
                      Console.WriteLine("O triângulo é acutângulo");
                 }
              }
              else
              {
                Console.WriteLine("Os ângulos não formam um triângulo");
              }
        }









    }
