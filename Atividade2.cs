/* Ref (5 pontos)
2 – Faça um programa que verifique se uma letra digitada é vogal ou consoante.
Nome:
*/
public static class Atividade2
{
      public static void Executar()
    {
         string letra;

           Console.WriteLine("Digite a letra");
              letra = Console.ReadLine()!.ToLower();
            
            
       if (letra == "a" || letra == "e" || letra == "i"  || letra == "o"  || letra == "u")
         {
          Console.WriteLine($"A letra \"{letra}\" é uma vogal");
         }
        else 
       {
      Console.WriteLine($"a letra\"{letra}\"é uma consoante");
       }
    }
}