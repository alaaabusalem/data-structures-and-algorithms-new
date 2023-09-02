using System.Reflection.Metadata.Ecma335;

namespace stack_and_queue
{
	public class Program
	{
		static void Main(string[] args)
		{

			// stack
			Console.WriteLine("the stack contain:");

			Stack<int> stack = new Stack<int>();
			stack.Push(1);
			stack.Push(2);
			stack.Push(3);
			stack.Push(4);
			stack.Print();
			Console.WriteLine($"the first element in the stack:{stack.Peek()}");
			Console.WriteLine("the stack contain after the first pop:");
			stack.Pop();
			stack.Print();
			Console.WriteLine("the stack contain after the second pop:");
			stack.Pop();
			stack.Print();

			// queue

			Queue<int> queue = new Queue<int>();
			Console.WriteLine("the queue contain:");
			queue.Enqueue(1);
			queue.Enqueue(2);
			queue.Enqueue(3);
			queue.Enqueue(4);
			queue.Print();
			Console.WriteLine($"the first element in the queue:{queue.Peek()}");
			Console.WriteLine("the queue contain after the first Dequeue:");
			queue.Dequeue();
			queue.Print();
			Console.WriteLine("the queue contain after the second Dequeue:");
			queue.Dequeue();
			queue.Print();
			///Pesedo
			Console.WriteLine("pseudoQueue");
			PseudoQueue<int> pseudoQueue = new PseudoQueue<int>();
			pseudoQueue.Enqueue(1);
			pseudoQueue.Enqueue(2);
			pseudoQueue.Enqueue(3);
			pseudoQueue.Enqueue(4);
			pseudoQueue.Print();
			Console.WriteLine("pseudoQueue");
			pseudoQueue.Dequeue();
			pseudoQueue.Print();
			Console.WriteLine("pseudoQueue");
			pseudoQueue.Dequeue();
			pseudoQueue.Print();

			///
			Console.WriteLine("CC 13");
			bool result = validateBrackets("{}(){}");
			Console.WriteLine(result);
			result = validateBrackets("()[[Extra Characters]]");
			Console.WriteLine(result);
			result = validateBrackets("[({}]");
			Console.WriteLine(result);
			result = validateBrackets("{(})");
			Console.WriteLine(result);



		}

		public static bool validateBrackets(string statement)
		{
			if (statement != null)
			{
				stack_and_queue.Queue<char> queue = new stack_and_queue.Queue<char>();
				stack_and_queue.Stack<char> stack = new stack_and_queue.Stack<char>();
				foreach (char s in statement)
				{

					if (s == '(' || s == ')' || s == '[' || s == ']' || s == '{' || s == '}')
					{
						queue.Enqueue(s);
					}
				}
				while (queue.count > 0)
				{
					char deque = queue.Dequeue();
					if (deque == '(' || deque == '[' || deque == '{')
					{
						stack.Push(deque);
					}
					else
					{
						if (stack.count == 0) { return false; }
						else
						{
							char pop = stack.Pop();
							if ((deque == ')' && pop == '(') || (deque == ']' && pop == '[') || (deque == '}' && pop == '{')) { continue; }
							else { return false; }
						}


					}
				}
				return true;
			}
			return false;
		}
		//CC 14



	}
}
