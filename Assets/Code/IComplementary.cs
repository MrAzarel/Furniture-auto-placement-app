using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IComplementary
{
    int[] ExtensionCoords { get; set; }

    void CalculateExtensionCoords();
}
