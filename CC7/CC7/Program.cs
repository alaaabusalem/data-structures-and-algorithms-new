using System;

public class MergeSort
{
	public static void Sort(int[] arr)
	{
		MergeSortRecursive(arr, 0, arr.Length - 1);
	}

	private static void MergeSortRecursive(int[] arr, int left, int right)
	{
		if (left < right)
		{
			int mid = (left + right) / 2;
			MergeSortRecursive(arr, left, mid);
			MergeSortRecursive(arr, mid + 1, right);
			Merge(arr, left, mid, right);
		}
	}

	private static void Merge(int[] arr, int left, int mid, int right)
	{
		int n1 = mid - left + 1;
		int n2 = right - mid;

		int[] leftArray = new int[n1];
		int[] rightArray = new int[n2];

		// Copy data to temporary arrays leftArray[] and rightArray[]
		for (int i = 0; i < n1; i++)
		{
			leftArray[i] = arr[left + i];
		}
		for (int j = 0; j < n2; j++)
		{
			rightArray[j] = arr[mid + 1 + j];
		}

		int x = 0, y = 0;
		int k = left;

		// Merge the temporary arrays back into arr[left..right]
		while (x < n1 && y < n2)
		{
			if (leftArray[x] <= rightArray[y])
			{
				arr[k] = leftArray[x];
				x++;
			}
			else
			{
				arr[k] = rightArray[y];
				y++;
			}
			k++;
		}

		// Copy remaining elements of leftArray[], if any
		while (x < n1)
		{
			arr[k] = leftArray[x];
			x++;
			k++;
		}

		// Copy remaining elements of rightArray[], if any
		while (y < n2)
		{
			arr[k] = rightArray[y];
			y++;
			k++;
		}
	}

	public static void Main(string[] args)
	{
		int[] arr = { 12, 11, 13, 5, 6, 7 };
		Console.WriteLine("Original Array:");
		PrintArray(arr);

		Sort(arr);

		Console.WriteLine("\nSorted Array:");
		PrintArray(arr);
	}

	private static void PrintArray(int[] arr)
	{
		foreach (var num in arr)
		{
			Console.Write(num + " ");
		}
		Console.WriteLine();
	}
}

