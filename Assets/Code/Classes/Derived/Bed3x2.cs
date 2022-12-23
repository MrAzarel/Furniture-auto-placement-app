public class Bed3x2 : Furniture, IRotatable<Bed3x2>, IWalled<Bed3x2>
{
    public Bed3x2(int width, int height) : base(width, height)
    {
        _id = 0;
    }
    //TODO: Create an algorithm responsible for furniture rotation
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

    //TODO: Finish the algorithm responsible for checking whether given furniture is correctly alligned with a wall
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

