using System;
using System.Linq;
using System.Collections.Generic;


class Program
{
	static void Main(string[] args)
	
	
		{
		Console.WriteLine("Introduceti greutatea unui om pe luna!");
		
		double greutate = double.Parse(Console.ReadLine());
		
		if(greutate < 0)
		{
			Console.WriteLine("A-ti introdus o greutate invalida. Greutatea nu poate avea valoare negativa! Încercati din nou!");
			
		}
		
		else if(greutate == 0)
	  {
	  	Console.WriteLine("Valoarea greutatii unii om nu poate fi de 0  kg !");
	  }
	 
		else
		{
			double campGravitationalLuna = 0.17;
			
			double rezultatGreutateOmPeLuna = 0;
			
			rezultatGreutateOmPeLuna = greutate * campGravitationalLuna;
			
			Console.WriteLine("Greutatea unui om pe luna este de " + rezultatGreutateOmPeLuna + " " + "kg");
		}
	
	}
}