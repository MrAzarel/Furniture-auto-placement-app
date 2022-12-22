using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IWalled<in T> where T : Furniture
{
    bool IsWalled(int[,] map, Furniture element);
}
    
