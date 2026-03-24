/*Ref (15 pontos)
4 – Ler valor de nota de N1 e N2, calcular a média e escrever a nota correspondente, 
tal que 0 é a menor nota e 10 a maior, e imprimir o conceito equivalente 
(A, B, C, D ou E), conforme a seguinte tabela:
A  -   nota >= 8,5  e nota <= 10
B  -   nota >= 7    e nota < 8,5
C  -   nota >= 5    e nota < 7
D  -   nota >= 3    e nota < 5
E  -   nota < 3
Nome:
*/
public static class Atividade4
{
      public static void Executar()
    {
        double nota1;
        double nota2;
        double media;

         Console.WriteLine("Digite a nota n1");
         nota1 = double.Parse(Console.ReadLine()!);

         Console.WriteLine("Digite a nota n2");
         nota2 = double.Parse(Console.ReadLine()!);

         media = (nota1 + nota2);

         Console.WriteLine("Digite a nota n2");
    }
}