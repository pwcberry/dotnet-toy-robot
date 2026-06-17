namespace ToyRobot.App;

public readonly struct Position(int x, int y)
{
    public int X => x;
    public int Y => y;
    
    public static Position Origin => new Position(0, 0);
}