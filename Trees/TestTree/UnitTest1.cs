using System.Collections.Generic;
using Trees;

namespace TestTree
{
	public class UnitTest1
	{
		[Fact]
		void TestInstantiateTreeWithRootValue()
		{
			// Arrange
	BinarySearchTree<int> binarySearchTree = new BinarySearchTree<int>();
			binarySearchTree.Add(50);

			// Act
			int count = binarySearchTree.Count;	
			// Assert
			Assert.Equal(1, count);
		}

		[Fact]
		void TestAddLeft()
		{
			// Arrange
			BinarySearchTree<int> binarySearchTree = new BinarySearchTree<int>();
			binarySearchTree.Add(50);
			binarySearchTree.Add(30);

			// Act
			int value = binarySearchTree.Root.Left.Value;
			// Assert
			Assert.Equal(30, value);
		}

		[Fact]
		void TestAddRight()
		{
			// Arrange
			BinarySearchTree<int> binarySearchTree = new BinarySearchTree<int>();
			binarySearchTree.Add(50);
			binarySearchTree.Add(70);

			// Act
			int value = binarySearchTree.Root.Right.Value;
			// Assert
			Assert.Equal(70, value);
		}

		[Fact]
		void TestSearchContains()
		{
			// Arrange
			BinarySearchTree<int> binarySearchTree = new BinarySearchTree<int>();
			binarySearchTree.Add(50);
			binarySearchTree.Add(30);
			binarySearchTree.Add(70);
			binarySearchTree.Add(20);
			binarySearchTree.Add(40);
			binarySearchTree.Add(60);

			// Act
			bool value = binarySearchTree.Contains(30);
			// Assert
			Assert.Equal(true, value);
		}
		[Fact]
		void TestSearchNotContains()
		{
			// Arrange
			BinarySearchTree<int> binarySearchTree = new BinarySearchTree<int>();
			binarySearchTree.Add(50);
			binarySearchTree.Add(30);
			binarySearchTree.Add(70);
			binarySearchTree.Add(20);
			binarySearchTree.Add(40);
			binarySearchTree.Add(60);

			// Act
			bool value = binarySearchTree.Contains(100);
			// Assert
			Assert.Equal(false, value);
		}

		[Fact]
		void TestPreOrder()
		{
			// Arrange
			BinarySearchTree<int> binarySearchTree = new BinarySearchTree<int>();
			binarySearchTree.Add(50);
			binarySearchTree.Add(30);
			binarySearchTree.Add(70);
			binarySearchTree.Add(20);
			binarySearchTree.Add(40);
			binarySearchTree.Add(60);

			// Act
			
			string resultString = string.Join(",", binarySearchTree.PreOrderTravarsel());
			// Assert
			Assert.Equal("50,30,20,40,70,60", resultString);
		}

		[Fact]
		void TestInOrder()
		{
			// Arrange
			BinarySearchTree<int> binarySearchTree = new BinarySearchTree<int>();
			binarySearchTree.Add(50);
			binarySearchTree.Add(30);
			binarySearchTree.Add(70);
			binarySearchTree.Add(20);
			binarySearchTree.Add(40);
			binarySearchTree.Add(60);

			// Act

		string resultString = string.Join(",", binarySearchTree.InorderTraversal());
			// Assert
			Assert.Equal("20,30,40,50,60,70", resultString);
		}

		[Fact]
		void TestPostOrder()
		{
			// Arrange
			BinarySearchTree<int> binarySearchTree = new BinarySearchTree<int>();
			binarySearchTree.Add(50);
			binarySearchTree.Add(30);
			binarySearchTree.Add(70);
			binarySearchTree.Add(20);
			binarySearchTree.Add(40);
			binarySearchTree.Add(60);

			// Act

			string resultString = string.Join(",", binarySearchTree.PostorderTraversal());
			// Assert
			Assert.Equal("20,40,30,60,70,50", resultString);
		}

		[Fact]
		void TestMaxValue()
		{
			// Arrange
			BinarySearchTree<int> binarySearchTree = new BinarySearchTree<int>();
			binarySearchTree.Add(50);
			binarySearchTree.Add(30);
			binarySearchTree.Add(70);
			binarySearchTree.Add(20);
			binarySearchTree.Add(40);
			binarySearchTree.Add(60);

			// Act

			int Max = binarySearchTree.MaxValue();	
			// Assert
			Assert.Equal(70, Max);
		}

		[Fact]
		void TestBreadthFirst()
		{
			// Arrange
			BinarySearchTree<int> binarySearchTree = new BinarySearchTree<int>();
			binarySearchTree.Add(50);
			binarySearchTree.Add(30);
			binarySearchTree.Add(70);
			binarySearchTree.Add(20);
			binarySearchTree.Add(40);
			binarySearchTree.Add(60);

			// Act

			 List<int> list = binarySearchTree.BreadthFirst();
			string answer = binarySearchTree.PrintBreadthFirst(list);
			// Assert
			Assert.Equal(answer, "50,30,70,20,40,60,null");
		}
	}
}