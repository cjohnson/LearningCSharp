using System;

Coords coordinates = new(1, 2);
coordinates.x = 23;

Console.WriteLine(coordinates);

public struct Coords
{
    public int x, y;

    public Coords(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public override string ToString() => $"[{x}, {y}]";
}