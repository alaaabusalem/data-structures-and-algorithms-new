namespace Trees
{
	internal class Program
	{
		static void Main(string[] args)
		{
			BinarySearchTree<int> binarySearchTree = new BinarySearchTree<int>();
			binarySearchTree.Add(50);
			binarySearchTree.Add(30);
			binarySearchTree.Add(70);
			binarySearchTree.Add(20);
			binarySearchTree.Add(40);
			binarySearchTree.Add(60);

			// Act

			BinarySearchTree<string> fizzbuzz = binarySearchTree.FizzBuzz(binarySearchTree);


			List<string> list  = fizzbuzz.PostorderTraversal();
			string resultString = fizzbuzz.PrintBreadthFirst(list);
			Console.WriteLine(resultString);

		}
	}
}