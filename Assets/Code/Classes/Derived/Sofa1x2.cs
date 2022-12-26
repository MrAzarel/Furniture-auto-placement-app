using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//TODO: Finish Sofa class
public class Sofa1x2 : Furniture //, IRotatable<Furniture>
{
    public Sofa1x2() : base(1, 2)
    {
    }

    public override void CalculateExtensionCoords()
    {
        throw new System.NotImplementedException();
    }

    public override void Submit()
    {
        throw new System.NotImplementedException();
    }

    /*public void RotateTo(Direction desiredDirection)
    {
        throw new System.NotImplementedException();
    }*/
}
