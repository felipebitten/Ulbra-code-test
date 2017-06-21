using System;

class mastercsIAC
{
    public static void Main()
    {
        int Comando = 0;

        do
        {
            Console.Clear();
            Console.WriteLine("Escolha o programa desejavél: ");
            Console.WriteLine("[1] Tabuada");
            Console.WriteLine("[2] Media");
            Console.WriteLine("[3] Calculadora");
            Console.WriteLine("[4] IMC");
            Console.WriteLine("[5] SAIR");
            Comando = int.Parse(Console.ReadLine());


            switch (Comando)
            {
              case 1:

                    int N1 = 0;
                    int Result = 0;

                    Console.Clear();
                    Console.WriteLine("Digite o número para a tabuada: ");
                    N1 = int.Parse(Console.ReadLine());

                    for (int i = 0; i <= 10; i++)
                    {
                          Result = N1 * i;
                          Console.WriteLine(N1 + " * " + i + " = " + Result);
                    }
                    Console.WriteLine("Pressione qualquer tecla para voltar");
                    Console.ReadLine();
                    break;

              case 2:
                    float G1 = 0;
                    float G2 = 0;
                    float Media = 0;

                    Console.Clear();
                    Console.WriteLine("Digite sua G1: ");
                    G1 = float.Parse(Console.ReadLine());

                    Console.WriteLine("Digite sua G2: ");
                    G2 = float.Parse(Console.ReadLine());

                    Media = (G1 + (G2 * 2))/3;

                       Console.WriteLine("Méda Final: {0:0.00}", Media);
                     if(Media >= 6)
                      {
                        Console.WriteLine("ALUNO APROVADO!");
                      }
                      else
                      {
                        Console.WriteLine("ALUNO REPROVADO!");
                      }
                      Console.WriteLine("Pressione qualquer tecla para voltar");
                      Console.ReadLine();
                  break;

                case 3:

                            float N1 = 0;
                            float N2 = 0;
                            float Result = 0;
                            string Oper = "";

                            Console.Clear();
                            Console.WriteLine("Digite um número:");
                            N1 = float.Parse(Console.ReadLine());

                            Console.WriteLine("Selecione a opcão:");
                            Console.WriteLine("[+] Soma:");
                            Console.WriteLine("[-] Subtração:");
                            Console.WriteLine("[*] Multiplicação:");
                            Console.WriteLine("[/] Divisão:");
                            Oper = Console.ReadLine();

                            Console.WriteLine("Digite mais um número:");
                            N2 = float.Parse(Console.ReadLine());

                          if(Oper == "+")
                          {
                            Result = N1 + N2;
                          }
                          else if(Oper == "-")
                          {
                            Result = N1 - N2;
                          }
                          else if(Oper == "*")
                          {
                            Result = N1 * N2;
                          }
                          else if(Oper == "/")
                          {
                            Result = N1 / N2;
                          }
                          else
                          {
                            Console.WriteLine("Comando Incorreto!");
                          }
                            Console.WriteLine("O resultado é: " + N1 + Oper + N2 +" = " + Result);
                            Console.WriteLine("Pressione qualquer tecla para voltar");
                            Console.ReadLine();
                      break;

              case 4:

                      float Peso = 0;
                      float Alt = 0;
                      float IMC = 0;
                      string Sexo = "";

                      Console.Clear();
                      Console.WriteLine("Informe qual seu sexo");
                      Console.WriteLine("M para Masculino || F para Feminino:");
                      Sexo = Console.ReadLine();

                      Console.WriteLine("Qual seu peso em kg? ");
                      Peso = float.Parse(Console.ReadLine());

                      Console.WriteLine("Qual sua altura em metros? ");
                      Alt = float.Parse(Console.ReadLine());

                      IMC = Peso/(Alt*Alt);
                      if(Sexo == "m" || Sexo == "M")
                        {
                          if(IMC < 20.7){
                              Console.WriteLine("Você esta abaixo do peso! Seu IMC é:", IMC);
                          } else if(IMC < 26.4){
                              Console.WriteLine("Você esta com o peso normal! Seu IMC é:", IMC);
                          } else if(IMC < 27.8){
                              Console.WriteLine("Você esta um pouco acima do peso! Seu IMC é:", IMC);
                          } else if(IMC < 31.1){
                              Console.WriteLine("Você esta acima do peso! Seu IMC é:", IMC);
                          } else{
                              Console.WriteLine("Você está com obesidade, cuidado! Seu IMC é:", Imc);
                            }
                      } else if(Sexo == "f" || Sexo == "F")
                        {
                          if(IMC < 19.1){
                                Console.WriteLine("Você esta abaixo do peso! Seu IMC é:", IMC);
                         } else if(IMC < 25.8){
                                Console.WriteLine("Você esta com o peso normal! Seu IMC é:", IMC);
                         } else if(IMC < 27.3){
                                Console.WriteLine("Você esta um pouco acima do peso! Seu IMC é:", IMC);
                         } else if(IMC < 32.3){
                                Console.WriteLine("Você esta acima do peso! Seu IMC é:", IMC);
                         } else{
                                Console.WriteLine("Você está com obesidade, cuidado! Seu IMC é:", IMC);
                            }
                        }
                        Console.WriteLine("Pressione qualquer tecla para voltar!");
                        Console.ReadLine();
                        break;

            }
        } while (Comando != 5);
    }
}
