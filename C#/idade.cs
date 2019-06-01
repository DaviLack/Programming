using System;

class jorje
{
	public static void Main(){
	
	int idade, meses, dias, legal;
	
	Console.WriteLine("Digite sua idade em anos, meses e dias: ");
	
	
	Console.Write("Digite os anos: ");
	idade = int.Parse(Console.ReadLine());
	
	Console.Write("Digite os meses: ");
	meses = int.Parse(Console.ReadLine());
	
	Console.Write("Digite os dias: ");
	dias = int.Parse(Console.ReadLine());
	
	idade = idade * 365;
	meses = meses * 30;
	
	legal = idade + meses + dias;
	
	Console.Write("Você tem {0} dias de vida.", +legal);

	
	}
}