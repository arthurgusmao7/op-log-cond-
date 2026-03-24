/*Ref. (10 pontos)
6 - Um programa deve ler três ângulos e verificar qual é o tipo de triângulo formado. 
Primeiro, é necessário conferir se a soma dos três ângulos é igual a 180°, 
pois só assim eles formam um triângulo. Depois, se um dos ângulos for igual a 90°, 
o triângulo é retângulo. Se um dos ângulos for maior que 90°, ele é obtusângulo. 
Caso contrário, se os três forem menores que 90°, o triângulo é acutângulo.
Nome:
*/public static class Atividade6
{
    public static void Executar()
    {
        int ang1, ang2, ang3;

        Console.WriteLine("Digite o primeiro ângulo:");
        ang1 = int.Parse(Console.ReadLine()!);

        Console.WriteLine("Digite o segundo ângulo:");
        ang2 = int.Parse(Console.ReadLine()!);

        Console.WriteLine("Digite o terceiro ângulo:");
        ang3 = int.Parse(Console.ReadLine()!);

        if (ang1 + ang2 + ang3 != 180)
        {
            Console.WriteLine("Os ângulos não formam um triângulo.");
        }
        else
        {
            if (ang1 == 90 || ang2 == 90 || ang3 == 90)
            {
                Console.WriteLine("Triângulo retângulo.");
            }
            else if (ang1 > 90 || ang2 > 90 || ang3 > 90)
            {
                Console.WriteLine("Triângulo obtusângulo.");
            }
            else
            {
                Console.WriteLine("Triângulo acutângulo.");
            }
        }
    }
}