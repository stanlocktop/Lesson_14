using System;
using System.Drawing;

interface IMovable
{
    void Move(int x, int y);
}

class Vehicle : IMovable
{
    public Point Position { get; set; } 

    public Vehicle(int x, int y)
    {
        Position = new Point(x, y);
    }

    public void Move(int x, int y)
    {
        Position = new Point(x, y);
    }
}

class Car : Vehicle
{
    public Car(int x, int y) : base(x, y) { }

    public void StartEngine()
    {
        Console.WriteLine("Двигун запущено");
    }

    public void StopEngine()
    {
        Console.WriteLine("Двигун зупинено");
    }
}