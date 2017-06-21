using System;

class Aula15IAC
{
    public static void Main ()
    {
      float N1=0;
      float N2=0;
      float Result=0;
      string Oper="";

      Console.WriteLine("Digite um numero: ");
      N1 = float.Parse(Console.ReadLine());

      Console.WriteLine("Selecione a opção + || - || * || /");
      Oper= Console.ReadLine();

      Console.WriteLine("Digite mais um numero: ");
      N2 = float.Parse(Console.ReadLine());

      if (Oper == "+"){
        Result = N1 + N2;
      }
      else if (Oper == "-"){
        Result = N1 - N2;
      }
      else if (Oper == "*"){
        Result = N1 * N2;
      }
      else if (Oper == "/") {
        Result = N1 / N2;
      }
      else
          Console.WriteLine("Erro com o operador!");

      Console.WriteLine("A soma é: " + Result);
      Console.ReadLine();
    }
}
