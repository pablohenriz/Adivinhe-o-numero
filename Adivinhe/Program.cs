// O while(true) faz o jogo inteiro rodar em loop para o "Jogar Novamente" funcionar
while (true)
{
     Console.Clear();
     // Variáveis iniciais base e essenciais
     Random numRandom = new Random();
     int numeroR = numRandom.Next(1, 11); // 1 a 10 (lembre-se que o 10 não entra no Next)
     int numUser = 0;
     int chances = 4;

     // Texto informativo
     Console.WriteLine("==== ADIVINHE O NUMERO ===");
     Console.WriteLine("Regras: O sistema escolheu um numero \ne voce tem 4 chances para adivinhar o numero.");
     Console.WriteLine(" ");
     Console.Write("Vamos comecar?(S/N) ");

     // .ToUpper() serve para aceitar "s" ou "S"
     string respo1 = Console.ReadLine()!.ToUpper();

     // Se a resposta for N, encerra o jogo inteiro
     if (respo1 == "N")
     {
          Console.WriteLine("Obrigado e ate mais");
          return; // O return fecha o programa na hora
     }

     Console.Clear();

     // Loop de palpites
     while (numUser != numeroR && chances > 0)
     {
          Console.WriteLine($"{chances} Chances");
          Console.WriteLine("");
          Console.Write("Digite um numero: ");

          // VALIDAÇÃO DE LETRA AQUI (O TryParse impede o erro)
          if (!int.TryParse(Console.ReadLine(), out numUser))
          {
               Console.WriteLine("ERRO: Digite apenas numeros!");
               Console.WriteLine("Pressione Enter para tentar de novo...");
               Console.ReadLine();
               Console.Clear();
               continue; // Volta para o início do while sem gastar chance
          }

          // Valida se ele errou
          if (numUser != numeroR)
          {
               chances = chances - 1;
               Console.WriteLine("VOCE ERROU!!!");
               Console.WriteLine("Pressione Enter para continuar...");
               Console.ReadLine(); // Dá uma pausa para o usuário ler o erro
               Console.Clear();
          }
     }

     // Quando o while acima termina, ele verificou duas coisas: acertou o número OU acabaram as chances

     if (numUser == numeroR) // Se ele acertou
     {
          Console.WriteLine("PARABENS VOCE ACERTOU!!!");
     }
     else // Se ele não acertou, significa que as chances acabaram
     {
          Console.WriteLine($"Acabaram as suas chances! O numero era {numeroR}.");
     }

     // Pergunta se quer jogar de novo
     Console.Write("Deseja tentar novamente?(S/N) ");
     string? tentar = Console.ReadLine()!.ToUpper();

     if (tentar != "S")
     {
          Console.WriteLine("Obrigado e ate mais!!");
          break; // O break quebra o while(true) lá de cima e encerra o programa
     }
}