using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Trees
{
	public class BinarySearchTree<T> : BinaryTree<T> where T : IComparable
	{ 
		public int Count { get; set; } = 0;
		public void Add(T value)
		{
			Root = AddNode(Root, value);
			Count++;
		}
		private Node<T> AddNode(Node<T> node, T value)
		{
			if (node == null)
				return new Node<T>(value);


			if (value.CompareTo(node.Value) < 0)
				node.Left = AddNode(node.Left, value);

			else if (value.CompareTo(node.Value) > 0)
				node.Right = AddNode(node.Right, value);

			return node;
		}

		public bool Contains (T value) {
			if(Root == null) return false;
			Node<T> pointer = Root;
			while (pointer != null)
			{
				if (pointer.Value.Equals(value)) { return true; }
				// check left
				//if (pointer.Left.Value.Equals(value))
				//{ return true; }
				//if (pointer.Right.Value.Equals(value))
				//{ return true; }
				if(value.CompareTo(pointer.Value) < 0)
				{
					pointer= pointer.Left;	
				}
				else { pointer = pointer.Right; }
			}

			
			return false;

		}

	}
}
