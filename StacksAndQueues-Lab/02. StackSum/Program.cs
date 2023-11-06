List<int> input = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();
Stack<int> stack = new Stack<int>(input);

string command = Console.ReadLine().ToLower();

while (command != "end")
{
    string[] splitCommand = command.Split();
    if (splitCommand[0] == "add")
    { 
        int first = int.Parse(splitCommand[1]);
        int second = int.Parse(splitCommand[2]);

        stack.Push(first);
        stack.Push(second);
    }

    if (splitCommand[0] == "remove")
    {
        int n = int.Parse(splitCommand[1]);
        if (n <= stack.Count)
        {
            for (int i = 0; i < n; i++)
            {
                stack.Pop();
            }
        }
    }
    command = Console.ReadLine().ToLower();
}

Console.WriteLine($"Sum: {stack.Sum()}");