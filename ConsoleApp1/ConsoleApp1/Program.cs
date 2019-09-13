using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			Random rnd = new Random();
			int randomNumber = rnd.Next(1, 100);
			int attemptCounter = 0;
			bool loopStatus = true;

			Console.WriteLine("Gissa vilket tal i talform datorn har valt!");

			while (loopStatus)
			{
				attemptCounter++;
				string inputString = Console.ReadLine();
				int userInt = int.Parse(inputString);

				if(randomNumber == userInt)
				{
					loopStatus = false;
					Console.WriteLine("Du gissade rätt. Grattis!");
					Console.WriteLine("Antal försök: " + attemptCounter);
				}
				else if(randomNumber < userInt)
				{
					Console.WriteLine("För högt.");
				}
				else if(randomNumber > userInt)
				{
					Console.WriteLine("För lågt.");
				}
			}
		}
	}
}
