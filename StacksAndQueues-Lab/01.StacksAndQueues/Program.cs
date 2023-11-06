using System.Collections; // <=

//Specially for C# where added these UTILITY METHODS:
//Stack<int> stack = new Stack<int>();
//int count = stack.Count;
//bool exists = stack.Contains(2);
//int[] array = stack.ToArray();
//stack.Clear(); -> remove all elements

// List<int>
Stack<int> stack = new Stack<int>();

stack.Push(1);
stack.Push(2);
stack.Push(3);

stack.Peek();
stack.Peek();
stack.Peek();

Console.WriteLine($"Stack count: {stack.Count}");
Console.WriteLine(stack.Pop());
Console.WriteLine($"Stack count: {stack.Count}");
Console.WriteLine(stack.Pop());
Console.WriteLine($"Stack count: {stack.Count}");
Console.WriteLine(stack.Pop());
Console.WriteLine($"Stack count: {stack.Count}");