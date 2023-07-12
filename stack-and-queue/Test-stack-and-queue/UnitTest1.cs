using System.Collections.Generic;
using stack_and_queue;

namespace Test_stack_and_queue
{
	public class UnitTest1
	{
		//Stack
		[Fact]
		void TestInstantiateAnEmptyStack()
		{
			// Arrange
			stack_and_queue.Stack<int> stack = new stack_and_queue.Stack<int>();

			// Act
			Node<int> node = stack.top;
			// Assert
			Assert.Equal(node, null);
		}

		[Fact]
		void TestPushOnToStack()
		{

			// Arrange
			stack_and_queue.Stack<int> stack = new stack_and_queue.Stack<int>();
			stack.Push(1);
			stack.Push(2);
			stack.Push(3);
			// Act
			int count = stack.count;
			// Assert
			Assert.Equal(count, 3);

		}

		[Fact]
		void TestPopOfTheStackAndPeekTheNextItem() {
			// Arrange
			stack_and_queue.Stack<int> stack = new stack_and_queue.Stack<int>();
			stack.Push(1);
			stack.Push(2);
			stack.Push(3);
			stack.Pop();
			// Act
			int topValue = stack.Peek();
			// Assert
			Assert.Equal(topValue, 2);
		}

		[Fact]
		void TestEmptyTheStackAfterMultiplePop()
		{
			// Arrange
			stack_and_queue.Stack<int> stack = new stack_and_queue.Stack<int>();
			stack.Push(1);
			stack.Push(2);
			stack.Push(3);
			stack.Pop();
			stack.Pop();
			stack.Pop();
			// Act

			// Assert
			Assert.Throws<Exception>(() => {
				stack.Pop();
			});
		}


		[Fact]
		void TestPeekAnEmptyStack()
		{
			// Arrange
			stack_and_queue.Stack<int> stack = new stack_and_queue.Stack<int>();
			
			// Act

			// Assert
			Assert.Throws<Exception>(() => {
				stack.Peek();
			});
		}
		//Queue

		[Fact]
		void TestInstantiateAnEmptyQueue()
		{
            // Arrange
            stack_and_queue.Queue<int> queue = new stack_and_queue.Queue<int>();

			// Act
			Node<int> node = queue.top;
			// Assert
			Assert.Equal(node, null);
		}

		[Fact]
		void TestEnqueueOnToQueue()
		{
			// Arrange
			stack_and_queue.Queue<int> queue = new stack_and_queue.Queue<int>();
			queue.Enqueue(1);
			queue.Enqueue(2);
			queue.Enqueue(3);
			// Act
			int count = queue.count;
			// Assert
			Assert.Equal(count, 3);
		}
		[Fact]
		void TestDequeueTheExpectedValue()
		{
			// Arrange
			stack_and_queue.Queue<int> queue = new stack_and_queue.Queue<int>();
			queue.Enqueue(1);
			queue.Enqueue(2);
			queue.Enqueue(3);
			// Act
			int dequeue = queue.Dequeue();
			// Assert
			Assert.Equal(dequeue, 1);
		}

		[Fact]
		void TestPeekIntoAQueue()
		{
			// Arrange
			stack_and_queue.Queue<int> queue = new stack_and_queue.Queue<int>();
			queue.Enqueue(1);
			queue.Enqueue(2);
			queue.Enqueue(3);
			// Act
			int peekValue = queue.Peek();
			// Assert
			Assert.Equal(peekValue, 1);
		}
		[Fact]
		void TestEmptyTheQueueAfterMultibledequeue()
		{
			// Arrange
			stack_and_queue.Queue<int> queue = new stack_and_queue.Queue<int>();
			queue.Enqueue(1);
			queue.Enqueue(2);
			queue.Enqueue(3);
			queue.Dequeue();
			queue.Dequeue();
			queue.Dequeue();
			// Act
			Node<int> node = queue.top;
			// Assert
			Assert.Equal(node, null);
		}


		[Fact]
		void TestPeekAnEmptyqueue()
		{
			// Arrange
			stack_and_queue.Queue<int> queue = new stack_and_queue.Queue<int>();

			// Act

			// Assert
			Assert.Throws<Exception>(() => {
				queue.Peek();
			});
		}
	} } 