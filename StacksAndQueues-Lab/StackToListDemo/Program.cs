List<int> list = new List<int>();

list.Add(1);
list.Add(2);
list.Add(3);

Console.WriteLine(list[list.Count-1]);
list.RemoveAt(list.Count-1);
//This has exact the same functionality that the stack, but the stack has
//an advantage the Stack OBLIGATES it work this way, it is useful for some algorithms
// More readable when you change algorithms etc:
//  Stack:
// when new dish -> add to stack
// when clean dish ->pop from stack
//  List:
// when new dish add it as a last element of the list of the dishes
// when cleaning dish get the last element
// from the list and then remove said element from the list

//Algorithm DFS Depth-first search usually needs a Stack
//Polish notation
//Shunting yard algorithm