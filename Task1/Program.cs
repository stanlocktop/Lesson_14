class Program
{
    static void Main(string[] args)
    {
        Car myCar = new Car(0, 0);
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.WriteLine("Початкова позиція:");
        Console.WriteLine($"X: {myCar.Position.X}, Y: {myCar.Position.Y}");

        myCar.StartEngine();
        myCar.Move(10, 20);
        Console.WriteLine("Автомобіль переміщено:");
        Console.WriteLine($"X: {myCar.Position.X}, Y: {myCar.Position.Y}");

        myCar.StopEngine();
        Console.ReadKey();
    }
}