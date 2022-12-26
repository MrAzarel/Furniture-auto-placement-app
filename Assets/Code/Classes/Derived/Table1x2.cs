public class Table1x2 : Furniture
{
    public Table1x2() : base(1, 2)
    {
        _id = 3;
        AtWall = false;
        Rotatable = true;
        ExtensionCoords = new int[4];
    }


    public override void CalculateExtensionCoords()
    {
        switch (FurnitureDirection)
        {
            case (Direction.Up):
                ExtensionCoords[0] = Pivot[0] - 1; ExtensionCoords[1] = Pivot[1];
                ExtensionCoords[2] = Pivot[0] + 1; ExtensionCoords[3] = Pivot[1] + 1;
                break;
            case (Direction.Down):
                ExtensionCoords[0] = Pivot[0] + 1; ExtensionCoords[1] = Pivot[1];
                ExtensionCoords[2] = Pivot[0] - 1; ExtensionCoords[3] = Pivot[1] - 1;
                break;
            case (Direction.Left):
                ExtensionCoords[0] = Pivot[0]; ExtensionCoords[1] = Pivot[1] + 1;
                ExtensionCoords[2] = Pivot[0] - 1; ExtensionCoords[3] = Pivot[1] - 1;
                break;
            case (Direction.Right):
                ExtensionCoords[0] = Pivot[0]; ExtensionCoords[1] = Pivot[1] - 1;
                ExtensionCoords[2] = Pivot[0] + 1; ExtensionCoords[3] = Pivot[1] + 1;
                break;
        }
    }
    public override void Submit()
    {
        IsPlaced = true;
        CalculateExtensionCoords();
    }
}
