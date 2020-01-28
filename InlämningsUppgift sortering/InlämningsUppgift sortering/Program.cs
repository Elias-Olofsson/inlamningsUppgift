using System;

namespace InlämningsUppgift_sortering
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] ickeSorteradArray = new int[10] { 2, 3, 8, 9, 2, 8, 2, 8, 0, 6 };
			BubbelSort(ickeSorteradArray);
			int plats = 0;
			while (plats < ickeSorteradArray.Length)
			{
				Console.WriteLine(ickeSorteradArray[plats]);
				plats = plats + 1;
			}

		}

		static int[] BubbelSort(int[] array)
		{
			for (int i = 0; i < array.Length-1; i++)
			{
				for (int j = 0; j < array.Length - 1 - i; j++)
				{
					if (array[j] > array[j+1])
					{
						int temp = array[j];
						array[j] = array[j + 1];
						array[j + 1] = temp;
					}
				}
			}
			return array;
		}

		static int[] IntersectionSort(int[] array)
		{
			int i
		}
	}
}
