using System;

class MediaUlbraCsharp
{
		public static void Main ()
		{
			float g1 = 0;
			float g2 = 0;
			float md = 0;
			
			Console.WriteLine("Digite a nota da G1: ");
			g1 = float.Parse(Console.ReadLine());
			
			Console.WriteLine("Digite a nota da G2: ");
			g2 = float.Parse(Console.ReadLine());
				
			md = (g1 + (g2*2))/3;
			
			Console.WriteLine("Sua média é: " + md);
				if (md>=6)
				Console.WriteLine("Você está a cima da média!");
				else
				Console.WriteLine("Você está REPROVADO!");
		Console.ReadLine();
		}
}