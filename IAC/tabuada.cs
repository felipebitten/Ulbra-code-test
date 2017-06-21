using System;

class tabuada
{
    public static void Main ()
    {
      int Num=0;
      int Result=0;
      string Comando = "";
do {
      Console.Clear();
      Escrever("Digite o número da tabuada: ");
      Num=int.Parse(Ler());

      for (int i=0; i<=10;i++)
      {
        Result = Num * i;
        Escrever (Num + " * " + i + " = " + Result);
      }
      Escrever ("");

      Escrever ("Digite 'fechar' para encerrar o programa ou qualquer outro digito para voltar!");
      Comando = Ler();

  } while (Comando != "fechar");

      }
      static void Escrever (string ParTexto)
      {
        Console.WriteLine(ParTexto);
      }
      static string Ler ()
      {
        return Console.ReadLine();
      }
      static void Parar ()
      {
      }
}
