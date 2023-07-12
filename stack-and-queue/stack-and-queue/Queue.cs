using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack_and_queue
{
	public class Queue <T>
	{
		public Node<T> top;
		public int count;
		public Queue()
		{
			top = null;
			count= 0;	
		}

		public void Enqueue(T value) {
		
			Node<T> newNode= new Node<T>(value);
			if(top == null) {
			top=newNode;
				count++;
			}
			else
			{
				Node<T> checkNode = top;
				while(checkNode != null) {
					if (checkNode.Next == null)
					{
						checkNode.Next = newNode;
						break;
					}
					checkNode = checkNode.Next;	
				}
				count++;	
			}
		}

		public T Dequeue()
		{

			if (top == null)
			{
				throw new Exception("The Queue is empty !!");
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
