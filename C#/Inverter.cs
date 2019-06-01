using System;

class Jorge
{
	
	public static void Main(String[] args) 
	{
	int A, B, C;
	
	Console.Write("Digite um  valor: ");
	A = int.Parse (Console.ReadLine());
	Console.Write("Digite um  valor: ");
	B = int.Parse (Console.ReadLine());
	
	C = A;
	A = B;
	B = C;
		Console.WriteLine("A = {0}", A);
		Console.WriteLine("B = {0}", B);
	}
}

