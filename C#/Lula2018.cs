using System;

class jorge
{

	public static void Main()

	{
		int eleitores, brancos, nulos, validos;
		
		Console.Write("Digite o número de Eleitores: ");
		eleitores = int.Parse(Console.ReadLine());
		
		Console.Write("Digite o número de votos válidos: ");
		validos = int.Parse(Console.ReadLine());
		
		Console.Write("Digite o número de votos brancos: ");
		brancos = int.Parse(Console.ReadLine());
		
		Console.Write("Digite o número de  nulos: ");
		nulos = int.Parse(Console.ReadLine());
		
		eleitores=brancos+nulos+validos;
		brancos = (brancos*100 )/eleitores;
		nulos = (nulos*100)/eleitores;
		validos = (validos*100) /eleitores;
		
		Console.WriteLine(+brancos+ "% votaram em BRANCO "+nulos+"% votaram NULO "+validos+"% votaram de Forma Válida ");
		
		
	}


}