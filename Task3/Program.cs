class Program
{
    static void Main(string[] args)
    {
        try
        {
            int a = 10;
            int b = 5;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine($"Додавання: {a} + {b} = {MathUtility.Додавання(a, b)}");
            Console.WriteLine($"Віднімання: {a} - {b} = {MathUtility.Віднімання(a, b)}");
            Console.WriteLine($"Множення: {a} * {b} = {MathUtility.Множення(a, b)}");
            int c = 10;
            int d = 0;
            Console.WriteLine($"Ділення: {c} / {d} = {MathUtility.Ділення(c, d)}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message);
            Console.ReadKey();
        }
    }
}