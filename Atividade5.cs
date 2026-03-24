/*Ref (15 pontos)
5 - As maçãs custam R$ 0,30 cada se forem compradas menos do que uma dúzia, 
e R$ 0,25 se forem compradas pelo menos doze. Escreva um programa que leia o número 
de maçãs compradas, calcule e escreva o valor total da compra.
Nome:
*/public static class Atividade5
{
    public static void Executar()
    {
        int maca;
        double preco;

        Console.WriteLine("Quantas maçãs foram compradas:");
        maca = int.Parse(Console.ReadLine()!);

        if (maca < 12)
        {
            preco = maca * 0.30;
        }
        else
        {
            preco = maca * 0.25;
        }

        Console.WriteLine($"O preço será R$ {preco}");
    }
}