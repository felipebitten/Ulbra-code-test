using System;

class FuncionarioNovo
{

	public static void Main()
	{
		int c1;
		float salario;
		
		Console.WriteLine("Digite 1 para técnico");
		Console.WriteLine("Digite 2 para gerente");
		Console.WriteLine("Digite 3 para outros");
		c1 = int.Parse(Console.ReadLine());
		
		if (c1>=4)
		Console.WriteLine("Numero Incorreto!");
		
		if (c1<=0)
		Console.WriteLine("Numero Incorreto!");
		
		Console.WriteLine("Digite seu salário: ");
		salario = float.Parse(Console.ReadLine());
		
		if (c1==1)
		{
		Console.WriteLine("Salário reajustado para: " + (salario+(salario*0.5)));
		}
		
		if (c1==2)
		{
		Console.WriteLine("Salário reajustado para: " + (salario+(salario*0.3)));
		}
		
		if (c1==3)
		{
		Console.WriteLine("Salário reajustado para: " + (salario+(salario*0.2)));
		}
	
		if (c1>=4)
		Console.WriteLine("Numero Incorreto!");
		
		if (c1<=0)
		Console.WriteLine("Numero Incorreto!");
	Console.ReadLine();
	}
}