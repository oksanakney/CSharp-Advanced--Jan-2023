namespace Exercise_StacksAndQueues
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

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < elementsToPush; i++) 
            {
                stack.Push(numbers[i]);
            }

            for (int i = elementsToPop; i > 0; i--)
            {
                stack.Pop();
            }

            if (stack.Contains(number))
            {
                Console.WriteLine("true");
            }
            if (!stack.Contains(number) && stack.Any())
            {
                int min = stack.Min();
                Console.WriteLine(min);
            }
            else if(!stack.Any())
            {
                Console.WriteLine("0");
            }      
        }
    }
}