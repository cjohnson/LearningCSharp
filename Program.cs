Coords coordinates = new(1, 2);
coordinates.x = 23;

System.Console.WriteLine(coordinates);

public struct Coords
{
    public int x, y;

    public Coords(int p1, int p2)
    {
        x = p1;
        y = p2;
    }

    public override string ToString()
    {
        return $"[{x}, {y}]";
    }
}