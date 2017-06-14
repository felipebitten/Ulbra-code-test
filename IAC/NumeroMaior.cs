using System;

class NumeroMaior
{
	public static void Main()
	{
		float n1;
		
		Console.WriteLine("Digite seu número: ");
		n1 = float.Parse(Console.ReadLine());
		
		if (n1>=30)
		
		Console.WriteLine("Seu número é maior que 30 e a metade dele é: " + (n1/2));
		else 
		Console.WriteLine("Seu número é menor que 30 e o dobro dele é: " + (n1*2));
		
	Console.ReadLine();
	}
}