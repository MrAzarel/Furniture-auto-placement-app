using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//TODO: Finish Closet class
public class Closet2x1 : Furniture, IRotatable<Furniture>, IWalled<Furniture>
{
    public Closet2x1(int width, int height) : base(width, height)
    {

    }

    public bool IsWalled(int[,] map, Furniture element)
    {
        throw new System.NotImplementedException();
    }

    public void RotateTo(Direction desiredDirection)
    {
        throw new System.NotImplementedException();
    }
}
