namespace _02.BasicQueueOperations
{
   
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tokens = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int elementsToPush = tokens[0];
            int elementsToPop = tokens[1];
            int number = tokens[2];

            Queue<int> queue = new Queue<int>();

            for (int i = 0; i < elementsToPush; i++)
            {
                queue.Enqueue(numbers[i]);
            }

            for (int i = elementsToPop; i > 0; i--)
            {
                queue.Dequeue();
            }

            if (queue.Contains(number))
            {
                Console.WriteLine("true");
            }
            if (!queue.Contains(number) && queue.Any())
            {
                int min = queue.Min();
                Console.WriteLine(min);
            }
            else if (!queue.Any())
            {
                Console.WriteLine("0");
            }
        }
    }
}