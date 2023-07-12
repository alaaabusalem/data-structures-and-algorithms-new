namespace stack_and_queue
{
	internal class Program
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

			Queue<int> queue= new Queue<int>();
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


		}
	}
}