namespace _01.ApocalypsePreparation;

internal class Program
{
    static void Main(string[] args)
    {
        Queue<int> textiles = new Queue<int>(Console.ReadLine().Split(" ").Select(int.Parse));
        Stack<int> meds = new Stack<int>(Console.ReadLine().Split(" ").Select(int.Parse));
        Dictionary<int, string> table = new Dictionary<int, string>()
        {
            {30, "Patch"},
            { 40 , "Bandage"},
            { 100 , "MedKit" }
        };
        Dictionary<string, int> items = new Dictionary<string, int>();        

        while (textiles.Any() && meds.Any())
        {
            int sum = textiles.Peek() + meds.Peek();

            if (table.Any(m => m.Key == sum))
            {
                if (!items.Any(a => a.Key == table[sum]))
                {
                    items.Add(table[sum], 0);
                }
                items[table[sum]]++;
                textiles.Dequeue();
                meds.Pop();
            }
            else
            {
                if (sum > 100)
                {
                    if (!items.Any(x => x.Key == "MedKit"))
                    {
                        items.Add("MedKit", 0);
                    }

                    items["MedKit"]++;

                    sum -= 100;
                    // Add value to the next element in the stack
                    meds.Pop();
                    meds.Push(meds.Pop() + sum);
                    textiles.Dequeue();
                }
                else
                {
                    textiles.Dequeue();
                    meds.Push(meds.Pop() + 10);
                }
            }           
        }

        if (!textiles.Any() && meds.Any())
        {
            Console.WriteLine("Textiles are empty.");
        }
        else if (!meds.Any() && textiles.Any())
        {
            
            Console.WriteLine("Medicaments are empty.");
        }
        if (!textiles.Any() && !meds.Any()) 
        {
            Console.WriteLine("Textiles and medicaments are both empty.");
        }

        foreach (var item in items.Where(i => i.Value > 0)
            .OrderByDescending(k => k.Value)
            .ThenBy(a => a.Key))
        {
            Console.WriteLine($"{item.Key} - {item.Value}");
        }

        if (meds.Any())
        {
            Console.WriteLine($"Medicaments left: {string.Join(", ",meds)}");
        }
        if (textiles.Any())
        {
            Console.WriteLine($"Textiles left: {string.Join(", ", textiles)}");
        }

    }
}
