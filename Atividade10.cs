/*Ref. (5 pontos)
10 - Escreva um programa que leia um número e verifique se ele é par ou ímpar.
Nome:
*/
public static class Atividade10
{
    public static void Executar()
    {
        int numero;

        Console.WriteLine("Digite um número:");
        numero = int.Parse(Console.ReadLine()!);

        if (numero % 2 == 0)
        {
            Console.WriteLine("Número par.");
        }
        else
        {
            Console.WriteLine("Número ímpar.");
        }
    }
}