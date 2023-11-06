namespace _01.OffroadChallenge;

internal class Program
{
    static void Main(string[] args)
    {
        Stack<int> fuels = new Stack<int>(Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse));
        Queue<int> consumptions = new Queue<int>(Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse));
        Queue<int> altitudes = new Queue<int>(Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse));
        int counter = 0;
        bool hasReachedAny = false;
        while (fuels.Any() && consumptions.Any())
        {
            counter++;
            int temp = fuels.Peek()-consumptions.Peek();


            if (temp >= altitudes.Peek())
            {
                hasReachedAny = true;
                fuels.Pop();
                consumptions.Dequeue();
                altitudes.Dequeue();
                Console.WriteLine($"John has reached: Altitude {counter}");
            }
            else 
            {
                Console.WriteLine($"John did not reach: Altitude {counter}");
                Console.WriteLine("John failed to reach the top.");

                if (hasReachedAny)
                {
                    Console.Write("Reached altitudes: ");
                    List<string> strings = new List<string>();
                    for (int i = 1; i < counter; i++)
                    {
                        strings.Add($"Altitude {i}");
                    }
                    Console.WriteLine(string.Join(", ", strings));
                }
                else 
                {
                    Console.WriteLine("John didn't reach any altitude.");
                }
                return;

            }
            if (altitudes.Count == 0) 
            {
                Console.WriteLine("John has reached all the altitudes and managed to reach the top!");
            }
             
        }
    }
}