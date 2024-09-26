namespace FirstHWFabricMethod;

using System;

public class LogovoKrys
{
    public int X { get; set; }
    public int Y { get; set; }

    public LogovoKrys(int x, int y)
    {
        X = x;
        Y = y;
    }

    public Rat CreateRat()
    {
        Random rand = new Random();
        int offsetX = rand.Next(-5, 6); // Генерация позиции рядом с логовом
        int offsetY = rand.Next(-5, 6);
        int ratX = X + offsetX;
        int ratY = Y + offsetY;
        Console.WriteLine($"Создана крыса рядом с логовом в точке ({ratX}, {ratY})");
        return new Rat(ratX, ratY);
    }
}

public class Rat
{
    public int X { get; set; }
    public int Y { get; set; }

    public Rat(int x, int y)
    {
        X = x;
        Y = y;
    }
}