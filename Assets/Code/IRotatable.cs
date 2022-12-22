using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IRotatable<T> where T: Furniture
{
    void RotateTo(Direction desiredDirection);
}
