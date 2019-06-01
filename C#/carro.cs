using System;

class jorje
{
	public static void Main(){
	
		decimal preco, distribuidor, imposto;
	
		Console.Write("Valor do veículo de fábrica: ");
		preco = decimal.Parse(Console.ReadLine());
		
		distribuidor = (preco * 28)/100;
		imposto = (preco * 45)/100;
		preco = distribuidor + preco + imposto;
		
		
		Console.Write("O valor total será de: " + preco);
		
	
	}
}