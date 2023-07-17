using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack_and_queue
{
	public class PseudoQueue<T>
	{
		stack_and_queue.Stack<T> mainStack;
		stack_and_queue.Stack<T> secondStack;
		public int count;
		public PseudoQueue()
		{
			mainStack = new stack_and_queue.Stack<T>();
			secondStack = new stack_and_queue.Stack<T>();
			count= 0;	

		}

		public void Enqueue(T value)
		{
			if (mainStack.top == null)
			{
				mainStack.Push(value);
				count++;	
			}
			else {
				secondStack = new Stack<T>() ;
				Node<T> node = mainStack.top;
				while (node != null)
				{
					secondStack.Push(node.Value);
					node = node.Next;
				}
				mainStack = new Stack<T>();
				Node<T> topMain = new Node<T>(value);
				mainStack.top = topMain;
				node = secondStack.top;
				while (node != null) {
					mainStack.Push(node.Value);
					node=node.Next;
				}
				count++;
			}
		}

		public T Dequeue()
		{

			if (mainStack.top == null)
			{
				throw new Exception("The Queue is empty !!");
			}
			else
			{
				T value = mainStack.top.Value;
				mainStack.top = mainStack.top.Next;
				count--;
				return value;
			}
		}

		public T Peek()
		{
			if (mainStack.top == null)
			{
				throw new Exception("The Stack is empty !!");
			}
			else
			{

				return mainStack.top.Value;
			}

		}

		public void Print()
		{
			if (mainStack.top != null)
			{
				Node<T> checkNode = mainStack.top;
				string answer = "";
				while (checkNode != null)
				{
					answer = answer + $"{checkNode.Value}-> ";
					checkNode = checkNode.Next;
				}
				Console.WriteLine(answer);
			}
		}

	

	}
}
