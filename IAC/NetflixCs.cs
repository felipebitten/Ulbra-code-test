using System;

class NetflixCs
{
    public static void Main()
    {
    int senha;
    int senha1;
    float born;
    int ncartao;
    int service;
    int plano;
    string nome;

    Console.WriteLine("Cadastre-se com seu nome no site: ");
    nome = Console.ReadLine();
    Console.WriteLine("Escolha sua senha: ");
    senha = int.Parse(Console.ReadLine());
    Console.WriteLine("Sua data de nascimento: ");
    born = float.Parse(Console.ReadLine());

      Console.WriteLine("Métodos de Pagamento:");
      Console.WriteLine("1- MasterCard");
      Console.WriteLine("2- Visa");
      service = int.Parse(Console.ReadLine());
      int i = 0;
      if (service==1) {
        do {

            Console.WriteLine("Digite sua senha para confirmar pagamento: ");
            senha1 = int.Parse(Console.ReadLine());
            if (senha!=senha1){
              Console.WriteLine("Senha Incorreta!");
              i = 0;
            }else {
              i=1;
            }

        } while (i==0);

        Console.WriteLine("Escolha seu plano Netflix:");
      Console.WriteLine("1 Tela R$19,90 Digite 1");
      Console.WriteLine("2 Telas R$24,90 Digite 2");
      Console.WriteLine("4 Telas R$29,90 Digite 3");
      plano = int.Parse(Console.ReadLine());

      if (plano==1)
      Console.WriteLine("VOCÊ ESCOLHEU O PLANO DE R$19,90");

      if (plano==2) {
        Console.WriteLine("VOCÊ ESCOLHEU O PLANO DE R$24,90");
      }

      if (plano==3) {
        Console.WriteLine("VOCÊ ESCOLHEU O PLANO DE R$29,90");
      }

      Console.WriteLine("Digite o numero do seu cartao (Bandeira: 7)");
      ncartao = int.Parse(Console.ReadLine());

      if ((ncartao>=700000000) & (ncartao<=799999999)){
        Console.WriteLine("PAGAMENTO CONCLUIDO!");

      }else{
        Console.WriteLine("NUMERO DE CARTAO INCORRETO! 9 DIGITOS BANDEIRA 7");
      do {
      Console.WriteLine("Digite o numero do seu cartao! (Bandeira 7)");
      ncartao = int.Parse(Console.ReadLine());
    } while (!((ncartao>=700000000) & (ncartao<=799999999)));
    Console.WriteLine("PAGAMENTO DO SEU PLANO CONCLUIDO");
    }
}
      if (service==2) {
        do {

            Console.WriteLine("Digite sua senha para confirmar pagamento: ");
            senha1 = int.Parse(Console.ReadLine());
            if (senha!=senha1){
              Console.WriteLine("Senha Incorreta!");
              i = 0;
            }else {
              i=1;
            }

        } while (i==0);

    Console.WriteLine("Escolha seu plano Netflix:");
    Console.WriteLine("1 Tela R$19,90 Digite 1");
    Console.WriteLine("2 Telas R$24,90 Digite 2");
    Console.WriteLine("4 Telas R$29,90 Digite 3");
    plano = int.Parse(Console.ReadLine());

    if (plano==1)
    Console.WriteLine("VOCÊ ESCOLHEU O PLANO DE R$19,90");

    if (plano==2) {
      Console.WriteLine("VOCÊ ESCOLHEU O PLANO DE R$24,90");
    }

    if (plano==3) {
      Console.WriteLine("VOCÊ ESCOLHEU O PLANO DE R$29,90");
    }

Console.WriteLine("Digite o numero do seu cartao (Bandeira: 8)");
ncartao = int.Parse(Console.ReadLine());

  if ((ncartao>=800000000) & (ncartao<=899999999)){
    Console.WriteLine("PAGAMENTO CONCLUIDO!");

  }else{
    Console.WriteLine("NUMERO DE CARTAO INCORRETO! 9 DIGITOS BANDEIRA 8");
  do {
  Console.WriteLine("Digite o numero do seu cartao! (Bandeira 8)");
  ncartao = int.Parse(Console.ReadLine());
} while (!((ncartao>=800000000) & (ncartao<=899999999)));
Console.WriteLine("PAGAMENTO DO SEU PLANO CONCLUIDO");
}
      }


      Console.ReadLine();
  }
}
