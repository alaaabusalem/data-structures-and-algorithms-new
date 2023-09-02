
using CC26;

Console.WriteLine("Hello, World!");

int[] input = { 4, 2, 7, 1, 9, 5 };

Sorting sortedArray = new Sorting();
int[] sorted = sortedArray.InsertionSort(input);

Console.WriteLine("Sorted array:");
foreach (int num in sorted)
{
	Console.Write(num + " ");
}
