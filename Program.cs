using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hur många heltal vill du skriva in?");
        int input = Convert.ToInt32(Console.ReadLine());
        int[] inputs = new int[input];

        Console.WriteLine("Skriv dina heltal nedan:");
        for (int i = 0; i < input; i++)
        {
            inputs[i] = Convert.ToInt32(Console.ReadLine());
        }

        Array.Sort(inputs);

        Console.WriteLine("Dina nummer sorterade från lägst till störst:");
        int number = 1;
        foreach (var element in inputs)
        {
            Console.WriteLine($"Tal {number}: {element}");
            number++;
        }
    }
}