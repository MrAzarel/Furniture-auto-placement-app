using UnityEngine;


//TODO: Assign IDs to the furniture
public abstract class Furniture //: MonoBehaviour
{
    protected int _id;
    protected int _row, _col; // _x2, _y2;
    protected Direction _furnitureDirection;
    protected int _width;
    protected int _height;


    protected bool Rotatable { get; set; }
    protected bool AtWall { get; set; }
    protected bool IsPlaced { get; set; }
    public int Id { get { return _id; } }
    public int[] Pivot { get; set; }
    public Direction FurnitureDirection
    {
        get { return _furnitureDirection; }
        set { _furnitureDirection = value; }
    }


    public Furniture(int width, int height)
    {
        FurnitureDirection = Direction.Up;

        Pivot = new int[] { _row = 0, _col = 0};
        IsPlaced = false;

        _width = width;
        _height = height;
    }


    public abstract void Submit();
}


public enum Direction
{
    Left = 1, Right = 2,
    Up = 3, Down = 4,
}
