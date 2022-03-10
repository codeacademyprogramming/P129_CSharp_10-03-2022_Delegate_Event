using System;
using System.Collections;

namespace P129ClassWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            queue.Enqueue("Hamid");
            queue.Enqueue("Perviz");
            queue.Enqueue("Vasif");
            queue.Enqueue("Alyasar");
            queue.Enqueue("Ceyhun");
            queue.Enqueue("Elgiz");

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("==========");

            foreach (var item in ReverseQueue(queue))
            {
                Console.WriteLine(item);
            }

        }

        static Queue ReverseQueue(Queue queue)
        {
            Stack stack = new Stack();
            for (int i = queue.Count; i > 0; i--)
            {
                stack.Push(queue.Dequeue());
            }

            for (int i = stack.Count; i > 0; i--)
            {
                queue.Enqueue(stack.Pop());
            }

            return queue;
        }
    }
}
