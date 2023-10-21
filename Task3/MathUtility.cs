using System;

public static class MathUtility
{
    public static int Додавання(int a, int b)
    {
        return a + b;
    }
    public static int Віднімання(int a, int b)
    {
        return a - b;
    }
    public static int Множення(int a, int b)
    {
        return a * b;
    }
    public static double Ділення(int a, int b)
    {
        if (b == 0)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            throw new DivideByZeroException("Помилка: Ділення на нуль!");
        }
        return (double)a / b;
    }
}