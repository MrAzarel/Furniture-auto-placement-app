using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Table : Furniture
{
    public Table(int width, int height) : base(width, height)
    {
    }

    public override void Submit()
    {
        throw new System.NotImplementedException();
    }
}
