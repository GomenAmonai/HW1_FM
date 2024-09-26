namespace FirstHWFabricMethod;
using System;

public class Goblin
{
    public int X { get; set; }
    public int Y { get; set; }

    private Goblin(int x, int y)
    {
        X = x;
        Y = y;
    }

    public static Goblin CreateRandomGoblin()
    {
        Random rand = new Random();
        int x = rand.Next(0, 100);
        int y = rand.Next(0, 100);
        Console.WriteLine($"Создан гоблин в точке ({x}, {y})");
        return new Goblin(x, y);
    }
}