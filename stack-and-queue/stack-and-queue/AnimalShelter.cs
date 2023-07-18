using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack_and_queue
{
	public class AnimalShelter
	{
		private Queue<Animal> dogQueue;
		private Queue<Animal> catQueue;

		public AnimalShelter()
		{
			dogQueue = new Queue<Animal>();
			catQueue = new Queue<Animal>();
		}

		public void Enqueue(Animal animal)
		{
			if (animal.Species == "dog")
			{
				dogQueue.Enqueue(animal);
			}
			else if (animal.Species == "cat")
			{
				catQueue.Enqueue(animal);
			}
		}

		public Animal Dequeue(string pref)
		{
			if (pref == "dog")
			{
				return dogQueue.count > 0 ? dogQueue.Dequeue() : null;
			}
			else if (pref == "cat")
			{
				return catQueue.count > 0 ? catQueue.Dequeue() : null;
			}
			else
			{
				return null;
			}
		}
	}
}
