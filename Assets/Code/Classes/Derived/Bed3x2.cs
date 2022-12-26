public class Bed2x3 : Furniture, IComplementary //, IRotatable<Bed3x2>, IWalled<Bed3x2>
{
    public int[] ExtensionCoords { get; set; }
    public Bed2x3() : base(2, 3)
    {
        _id = 0;

        Rotatable = true;
        AtWall = true;
        ExtensionCoords = new int[4];
    }

    public override void Submit()
    {
        IsPlaced = true;
        CalculateExtensionCoords();
    }

    //Should be called after a suitable place in the map is found
    public void CalculateExtensionCoords()
    {
        switch (FurnitureDirection)
        {
            case (Direction.Up):
                ExtensionCoords[0] = Pivot[0] - 1; ExtensionCoords[1] = Pivot[1] + 2;
                ExtensionCoords[2] = Pivot[0] + 2; ExtensionCoords[3] = Pivot[1] + 2;
                break;
            case (Direction.Down):
                ExtensionCoords[0] = Pivot[0] + 1; ExtensionCoords[1] = Pivot[1] - 2;
                ExtensionCoords[2] = Pivot[0] - 2; ExtensionCoords[3] = Pivot[1] - 2;
                break;
            case (Direction.Left):
                ExtensionCoords[0] = Pivot[0] - 2; ExtensionCoords[1] = Pivot[1] - 1;
                ExtensionCoords[2] = Pivot[0] - 2; ExtensionCoords[3] = Pivot[1] + 2;
                break;
            case (Direction.Right):
                ExtensionCoords[0] = Pivot[0] + 2; ExtensionCoords[1] = Pivot[1] - 2;
                ExtensionCoords[2] = Pivot[0] + 2; ExtensionCoords[3] = Pivot[1] + 1;
                break;
        }
    }

    // 
    //TODO: (It might be unnecessary to do here!) Create an algorithm responsible for furniture rotation
    public void RotateTo(Direction desiredDirection)
    {
        if (desiredDirection != FurnitureDirection)
        {
            switch (desiredDirection)
            {
                case Direction.Right:
                    {
                        #region ToRight
                        //// Creating new upside down matrix
                        //int[,] result = new int[origin.GetLength(1), origin.GetLength(0)];

                        //for (int i = 0; i < origin.GetLength(0); i++)
                        //{
                        //    for (int j = 0; j < origin.GetLength(1); j++)
                        //    {
                        //        // Turn to the right
                        //        result[j, origin.GetLength(0) - i - 1] = origin[i, j];
                        //    }
                        //}

                        //// Return new matrix
                        //return result;
                        break;
                        #endregion
                    }

                case (Direction.Left):
                    {
                        #region ToLeft

                        //int[,] result = new int[origin.GetLength(1), origin.GetLength(0)];

                        //for (int i = 0; i < origin.GetLength(0); i++)
                        //{
                        //    for (int j = 0; j < origin.GetLength(1); j++)
                        //    {
                        //        result[origin.GetLength(1) - j - 1, i] = origin[i, j];
                        //    }
                        //}
                        //return result;
                        break;
                        #endregion
                    }

                default:
                    break;
            }


        }
        return;
    }

    //TODO: (It might be unnecessary to do here!) Finish the algorithm responsible for checking whether given furniture is correctly alligned with a wall
    public bool IsWalled(int[,] map, Furniture element)
    {
        for (int i = 0; i < map.GetLength(0); i++)
        {
            if (i == map.GetLength(0) - 1 || i == 0)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {

                }
            }
        }
        return false;
    }
}

