//TODO: Finish Closet class
public class Closet2x2 : Furniture //, IRotatable<Furniture>, IWalled<Furniture>
{
    public Closet2x2() : base(2, 2)
    {
        _id = 4;
    }

    public override void CalculateExtensionCoords()
    {
    }

    public override void Submit()
    {
        IsPlaced= true;
    }
}
