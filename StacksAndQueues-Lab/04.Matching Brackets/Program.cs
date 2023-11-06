namespace _04.Matching_Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 + (2 - (2 + 3) * 4 / (3 + 1)) * 5
            string expression = Console.ReadLine();
            Stack<int> openBracketIndexes = new Stack<int>();

            for (int i = 0; i< expression.Length; i++) 
            { 
                if (expression[i] == '(') 
                { 
                    openBracketIndexes.Push(i);
                }
                if (expression[i] == ')')
                {
                    int openBracket = openBracketIndexes.Pop();

                    for (int j = openBracket; j <= i; j++) 
                    {
                        Console.Write(expression[j]);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}