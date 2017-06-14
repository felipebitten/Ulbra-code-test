using System;

class estoquePTC
{
	public static void Main()
	{

    int qest;
    int qmax;
    int qmin;
    float md;

	   Console.WriteLine("Quantidade atual em estoque: ");
     qest = int.Parse(Console.ReadLine());
	   Console.WriteLine("Quantidade máxima em estoque: ");
     qmax = int.Parse(Console.ReadLine());
     Console.WriteLine("Quantidade minima em estoque: ");
     qmin = int.Parse(Console.ReadLine());

     md= (qmax + qmin)/2;

     if (md>=qest)
     Console.WriteLine("Não efetuar compra!");
     else
     Console.WriteLine("Efetuar compra!");

     Console.ReadLine();
	}
}
