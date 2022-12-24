public class Chair1x1 : Furniture
{
    public Chair1x1(int width, int height) : base(width, height)
    {
        _id = 1;
    }

    public override void Submit()
    {
        throw new System.NotImplementedException();
    }
}
