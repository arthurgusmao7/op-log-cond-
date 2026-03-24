/*Ref. (5 pontos)
9 - Escreva um programa que leia um número e verifique se ele é positivo,
negativo ou zero.
Nome:
*/
public static class Atividade9
{
    public static void Executar()
    {
        double numero;

        Console.WriteLine("Digite um número:");
        numero = double.Parse(Console.ReadLine()!);

        if (numero > 0)
        {
            Console.WriteLine("Número positivo.");
        }
        else if (numero < 0)
        {
            Console.WriteLine("Número negativo.");
        }
        else
        {
            Console.WriteLine("Número é zero.");
        }
    }
}

