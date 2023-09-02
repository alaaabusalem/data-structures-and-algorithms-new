using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC26
{
	public class Sorting
	{
		public void Insert(int[] sorted, int value)
		{
			int i = 0;
			while (i < sorted.Length && value > sorted[i])
			{
				i++;
			}
			while (i < sorted.Length)
			{
				int temp = sorted[i];
				sorted[i] = value;
				value = temp;
				i++;
			}
		}

		public int[] InsertionSort(int[] input)
		{
			int[] sorted = new int[input.Length];
			sorted[0] = input[0];
			for (int i = 1; i < input.Length; i++)
			{
				Insert(sorted, input[i]);
			}
			return sorted;
		}
	}
}
