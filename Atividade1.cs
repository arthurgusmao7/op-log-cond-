/*Ref (5 pontos)
1 - Faça um programa que calcule e apresente o valor do volume de uma lata, 
sabendo que PI é um valor constante de 3.14159, o programa deve pedir os valores 
de RAIO e ALTURA, utilize a fórmula VOLUME = PI * RAIO² * ALTURA.
Nome:
*/
using System.Linq.Expressions;

public static class Atividade1
{
      public static void Executar()
    {    
        double altura;
        double PI = 3.14159;
        double volume;
        double raio ;

          Console.WriteLine("Digite altura da lata: ");
          altura = double.Parse(Console.ReadLine()!);
          
          Console.WriteLine();

          Console.WriteLine("Digite o Raio da lata: ");
          raio  = double.Parse(Console.ReadLine()!);
           
           Console.WriteLine();
    
        volume = PI * (raio * raio) * altura;
        Console.WriteLine($" valor do volume da lata é {volume}");
          
    }
}