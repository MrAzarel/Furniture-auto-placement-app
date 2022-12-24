using UnityEngine;


//TODO: Assign IDs to the furniture
public abstract class Furniture : MonoBehaviour
{
    protected int _id;
    protected int _x, _y; // _x2, _y2;
    protected Direction _furnitureDirection;
    protected int _width;
    protected int _height;
    protected bool Rotatable { get; set; }
    protected bool AtWall { get; set; }

    protected bool IsPlaced { get; set; }
    public int Id { get { return _id; } }
    public Direction FurnitureDirection
    {
        get { return _furnitureDirection; }
        set { _furnitureDirection = value; }
    }
    public int[] Pivot { get; set; }

    public Furniture(int width, int height)
    {
        Pivot = new int[] { _x = 0, _y = 0};
        IsPlaced = false;

        _width = width;
        _height = height;
    }
    /*// Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }*/
}


public enum Direction
{
    Left = 1, Right = 2,
    Up = 3, Down = 4,
}
