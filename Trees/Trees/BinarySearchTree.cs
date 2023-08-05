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
		public T MaxValue()
		{
			//if (Root == null) return null;
			Node<T> pointer = Root;
			T Max = Root.Value;
			pointer = Root.Right;
			while (pointer != null) {
				if (pointer.Right == null) ;
				Max=pointer.Value;
				pointer=pointer.Right;
			}

			return Max;	

		}

		public List<T> BreadthFirst()
		{
			//if (Root == null) return null;
			Node<T> pointer = Root;
			List<T> list = new List<T>();
			list.Add(pointer.Value);	
			Queue<Node<T>> queue = new Queue<Node<T>>();
			queue.Enqueue(pointer);	
			while (queue.Count !=0) {
				if (queue != null)
				{
					Node<T> node = queue.Dequeue();

					if (node.Left != null)
					{
						queue.Enqueue(node.Left);
						list.Add(node.Left.Value);
					}

					if (node.Right != null)
					{
						queue.Enqueue(node.Right);
						list.Add(node.Right.Value);
					}
				}
			}
			
		  return list;	
					

			}
			 
		     public string PrintBreadthFirst(List<T> list)
		{
			string answer = "";
			foreach (var item in list)
			{
				answer += $"{item},";
			}
			answer += "null";
			return answer;
		}

		}
	}

