namespace Trees
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");
			//BinarySearchTree<int> binarySearchTree = new BinarySearchTree<int>();
			BinarySearchTree<int> binarySearchTree = new BinarySearchTree<int>();
			binarySearchTree.Add(50);
			binarySearchTree.Add(30);
			binarySearchTree.Add(70);
			binarySearchTree.Add(20);
			binarySearchTree.Add(40);
			binarySearchTree.Add(60);

			// Act

			List<int> list = binarySearchTree.BreadthFirst();
			
			Console.WriteLine(binarySearchTree.PrintBreadthFirst(list));
		}
	}
}