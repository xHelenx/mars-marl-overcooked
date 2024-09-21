using Mars.Interfaces.Environments;
namespace OvercookedBox;

public abstract class Direction
{
    public static readonly Position North = new(0, 1);
    public static readonly Position East = new(1, 0);
    public static readonly Position South = new(0, -1);
    public static readonly Position West = new(-1, 0);
    
}