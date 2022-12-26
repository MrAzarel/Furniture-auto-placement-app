using System;
using UnityEngine;


//TODO: Assign IDs to the furniture
public abstract class Furniture: IComparable<Furniture>, IComplementary //: MonoBehaviour
{
    protected int _id;
    protected int _row, _col; // _x2, _y2;
    protected Direction _furnitureDirection;
    protected int _width;
    protected int _height;

    public int[] ExtensionCoords { get; set; }
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

    
    public Furniture(int height, int width)
    {
        FurnitureDirection = Direction.Up;

        Pivot = new int[] { _row = 0, _col = 0};
        IsPlaced = false;
        _height = height;
        _width = width;
    }


    public abstract void Submit();

    public abstract void CalculateExtensionCoords();

    public int CompareTo(Furniture other)
    {
        if (other == null) return 1;

        return _width*_height.CompareTo(other._width*other._height);
    }
    public static bool operator > (Furniture operand1, Furniture operand2)
    {
        return operand1.CompareTo(operand2) > 0;
    }
    public static bool operator < (Furniture operand1, Furniture operand2)
    {
        return operand1.CompareTo(operand2) < 0;
    }
    public static bool operator >= (Furniture operand1, Furniture operand2)
    {
        return operand1.CompareTo(operand2) >= 0;
    }
    public static bool operator <= (Furniture operand1, Furniture operand2)
    {
        return operand1.CompareTo(operand2) <= 0;
    }
}


public enum Direction
{
    Left = 1, Right = 2,
    Up = 3, Down = 4,
}
