namespace _01.TempleOfDoom;

internal class Program
{
    static void Main(string[] args)
    {
        Queue<int> tools = new Queue<int>(Console.ReadLine()
            .Split(" ")
            .Select(int.Parse));
        Stack<int> substances = new Stack<int>(Console.ReadLine()
                .Split(" ")
                .Select(int.Parse));            

        List<int> challenges = new List<int>(Console.ReadLine()
            .Split(" ")
            .Select(int.Parse));       

        while (tools.Any() && substances.Any())
        { 
            int multiplication = tools.Peek() * substances.Peek();

            if (challenges.Contains(multiplication)) 
            { 
                tools.Dequeue();
                substances.Pop();
                challenges.Remove(multiplication); 
                if (challenges.Count == 0)
                {
                    Console.WriteLine("Harry found an ostracon, which is dated to the 6th century BCE.");
                    break;
                }
            }
            
            else
            {
                tools.Enqueue(tools.Dequeue() + 1);                              
                substances.Push(substances.Pop() - 1);
                if (substances.Peek() == 0)
                {
                    substances.Pop();
                }
                
                if (substances.Count == 0)
                {
                    Console.WriteLine("Harry is lost in the temple. Oblivion awaits him.");
                    break;
                }
            }
            
        }             
        
        if (tools.Any())
        {
            Console.WriteLine($"Tools: {string.Join(", ", tools)}");
        }
        if (substances.Any())
        {
            Console.WriteLine($"Substances: {string.Join(", ", substances)}");
        }
        if (challenges.Count > 0)
        {
            Console.WriteLine($"Challenges: {string.Join(", ", challenges)}");
        }       
        
    }
}