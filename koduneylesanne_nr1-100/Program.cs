using System;

namespace koduneylesanne_nr1_100
{
	class Program
	{
		static void Main(string[] args)
		{
			// luua uus massiiv: numbrid 1-100 ja liidame need kokku
			

			int[] numbers = new int[100]; //kandilised on masiiv tähis, me loeme uue objekti; 100- kastikest, elementide arv
			//double sum = 0; //see on vajalik alloleva keskmise arvutamiseks
			int sum = 0;

			for (int i = 0; i < numbers.Length; i++) //kui ma alustan ühest, siis ta sisse ei pane
			{
				numbers[i] = i + 1; //i genereerib meile numbrid, i on alguses 0, siis 1 jne,
			}

			foreach( int num in numbers)
			{
				Console.WriteLine(num);
				sum = sum + num;
			}
					   
			Console.WriteLine(sum);

			//leida nende numbrite keskmine

			/*double average = sum / numbers.Length;
			Console.WriteLine(average);*/

			Console.ReadLine();
		}
	}
}
