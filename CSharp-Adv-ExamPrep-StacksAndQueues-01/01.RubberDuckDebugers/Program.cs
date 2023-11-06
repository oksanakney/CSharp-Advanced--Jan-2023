namespace _01.RubberDuckDebuggers;

internal class Program
{
    static void Main(string[] args)
    {
        Queue<int> times = new Queue<int>(Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse).ToArray());

        Stack<int> tasks = new Stack<int>(Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse).ToArray());
        Dictionary<string, int> ducks = new Dictionary<string, int>()
        {
            { "Darth Vader Ducky", 0 },
            { "Thor Ducky", 0},
            { "Big Blue Rubber Ducky", 0},
            { "Small Yellow Rubber Ducky", 0}
        };

        while(times.Any() && tasks.Any())
        {
            int time = times.Peek();
            int task = tasks.Peek();
            int mult = time * task;

            if (mult >= 0 && mult <= 240)
            {
                if (mult >= 0 && mult <= 60)
                {
                    ducks["Darth Vader Ducky"]++;
                }
                else if (mult >= 61 && mult <= 120)
                {
                    ducks["Thor Ducky"]++;
                }
                else if (mult >= 121 && mult <= 180)
                {
                    ducks["Big Blue Rubber Ducky"]++;
                }
                else
                {
                    ducks["Small Yellow Rubber Ducky"]++;
                }
                times.Dequeue();
                tasks.Pop();
                continue;
            }
            else 
            { 
                tasks.Push(tasks.Pop()-2);
                times.Enqueue(times.Dequeue());
            }
        }
        Console.WriteLine("Congratulations, all tasks have been completed! Rubber ducks rewarded:");
       foreach(var duck in ducks)
        {
            Console.WriteLine($"{duck.Key}: {duck.Value}");
        }
    }
}