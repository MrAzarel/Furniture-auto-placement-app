public class Bed3x2 : Furniture, IRotatable<Bed3x2>, IWalled<Bed3x2>
{
    public Bed3x2(int width, int height) : base(width, height)
    {
        id = 0;
    }
    //TODO: Create an algorithm responsible for furniture rotation
    public void RotateTo(Direction desiredDirection)
    {
        if (desiredDirection != FurnitureDirection)
        {

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

