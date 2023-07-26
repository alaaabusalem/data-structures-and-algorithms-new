using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace stack_and_queue
{
	public class Stack<T>
	{
		public Node<T> top;
		public int count;
		public Stack()
		{
			top = null;
			count = 0;
		}

		// Push
		public void Push(T value)
		{
			Node<T> newNode = new Node<T>(value);
			if (top == null)
			{
				top = newNode;

			}
			else
			{
				newNode.Next = top;
				top = newNode;
			}
			count++;	
		}

		// Pull
		public T Pop()
		{
			if (top == null)
			{
				throw new Exception("The Stack is empty !!");
			}
			else
			{
				T value = top.Value;
				top = top.Next;
				count--;

				return value;
			}
		}

		public T Peek()
		{
			if (top == null)
			{
				throw new Exception("The Stack is empty !!");
			}
			else
			{

				return top.Value;
			}

		}

		public bool IsEmpty()
		{
			if (top == null)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		public void Print()
		{
			if (top != null)
			{
				Node<T> checkNode = top;

				while (checkNode != null)
				{
					Console.WriteLine(checkNode.Value);
					checkNode = checkNode.Next;
				}
			}
		}
	

	}
}
