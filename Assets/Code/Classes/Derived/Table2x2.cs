public class Table2x2 : Furniture
{
    public Table2x2() : base(2, 2)
    {
        _id = 2;
        ExtensionCoords = new int[8];
        Rotatable = false;
        AtWall= false;
    }


    public override void CalculateExtensionCoords()
    {
        switch (FurnitureDirection)
        {
            case (Direction.Up):
                ExtensionCoords[0] = Pivot[0] - 1; ExtensionCoords[1] = Pivot[1];
                ExtensionCoords[2] = Pivot[0] + 1; ExtensionCoords[3] = Pivot[1] - 1;
                ExtensionCoords[4] = Pivot[0]; ExtensionCoords[5] = Pivot[1] + 2;
                ExtensionCoords[6] = Pivot[0] + 2; ExtensionCoords[7] = Pivot[1] + 1;
                break;
            case (Direction.Down):
                ExtensionCoords[0] = Pivot[0] - 1; ExtensionCoords[1] = Pivot[1];
                ExtensionCoords[2] = Pivot[0] + 1; ExtensionCoords[3] = Pivot[1] - 1;
                ExtensionCoords[4] = Pivot[0]; ExtensionCoords[5] = Pivot[1] + 2;
                ExtensionCoords[6] = Pivot[0] + 2; ExtensionCoords[7] = Pivot[1] + 1;
                break;
            case (Direction.Left):
                ExtensionCoords[0] = Pivot[0] - 1; ExtensionCoords[1] = Pivot[1];
                ExtensionCoords[2] = Pivot[0] + 1; ExtensionCoords[3] = Pivot[1] - 1;
                ExtensionCoords[4] = Pivot[0]; ExtensionCoords[5] = Pivot[1] + 2;
                ExtensionCoords[6] = Pivot[0] + 2; ExtensionCoords[7] = Pivot[1] + 1;
                break;
            case (Direction.Right):
                ExtensionCoords[0] = Pivot[0] - 1; ExtensionCoords[1] = Pivot[1];
                ExtensionCoords[2] = Pivot[0] + 1; ExtensionCoords[3] = Pivot[1] - 1;
                ExtensionCoords[4] = Pivot[0]; ExtensionCoords[5] = Pivot[1] + 2;
                ExtensionCoords[6] = Pivot[0] + 2; ExtensionCoords[7] = Pivot[1] + 1;
                break;
        }
    }
    public override void Submit()
    {
        IsPlaced = true;
        CalculateExtensionCoords();
    }
}
