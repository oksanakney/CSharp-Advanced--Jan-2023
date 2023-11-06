string input = Console.ReadLine();
Stack<char> stack = new Stack<char>();

//var is syntactic sugar var -- Stack<char>
foreach (var character in input)
{ 
    stack.Push(character);
}
//Console.WriteLine(stack.Count);

//Usually with Stacks we use while cycle because we don't know the quantity.
//But if we know it, we can use for cycle
while (stack.Count != 0)
{
    Console.Write(stack.Pop());
}

//Why do the Stack exist?
//Watch StackToListDemo
