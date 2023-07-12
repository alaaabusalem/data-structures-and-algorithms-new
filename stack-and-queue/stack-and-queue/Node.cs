using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack_and_queue
{
	public class Node <T>
	{
		public T Value { get; set; }
		public Node<T> Next;

		public Node(T value)
		{
			this.Value = value;
			Next = null;	
		}

	}
}
