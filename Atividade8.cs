/*Ref. (10 pontos)
8 - Crie um programa que faça 5 perguntas para uma pessoa sobre um crime. 
As perguntas são:
"Telefonou para a vítima?"
"Esteve no local do crime?"
"Mora perto da vítima?"
"Devia para a vítima?"
"Já trabalhou com a vítima?"
O programa deve, no final, emitir uma classificação sobre a participação da pessoa no 
crime. Se a pessoa responder positivamente a 2 questões, ela deve ser 
classificada/exibida como "Suspeita", entre 3 e 4 como "Cúmplice" e 5 como "Assassino". 
Caso contrário, ela será classificada como "Inocente".
Aluno:
*/public static class Atividade8
{
    public static void Executar()
    {
        int contador = 0;
        string resposta;

        Console.WriteLine("Responda com S (sim) ou N (não)\n");

        Console.WriteLine("Telefonou para a vítima?");
        resposta = Console.ReadLine()!.ToUpper();
        if (resposta == "S") contador++;

        Console.WriteLine("Esteve no local do crime?");
        resposta = Console.ReadLine()!.ToUpper();
        if (resposta == "S") contador++;

        Console.WriteLine("Mora perto da vítima?");
        resposta = Console.ReadLine()!.ToUpper();
        if (resposta == "S") contador++;

        Console.WriteLine("Devia para a vítima?");
        resposta = Console.ReadLine()!.ToUpper();
        if (resposta == "S") contador++;

        Console.WriteLine("Já trabalhou com a vítima?");
        resposta = Console.ReadLine()!.ToUpper();
        if (resposta == "S") contador++;

        Console.WriteLine();

        if (contador == 2)
        {
            Console.WriteLine("Classificação: Suspeita");
        }
        else if (contador >= 3 && contador <= 4)
        {
            Console.WriteLine("Classificação: Cúmplice");
        }
        else if (contador == 5)
        {
            Console.WriteLine("Classificação: Assassino");
        }
        else
        {
            Console.WriteLine("Classificação: Inocente");
        }
    }
}