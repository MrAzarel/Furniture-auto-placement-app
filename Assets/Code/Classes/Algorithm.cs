using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlacingAlgorithm<T> where T: Furniture
{
    private int[,] Map { get; set; }

    private Direction[] Walls { get;}
    private Furniture[] FurnitureToPlace { get; set; }



    public PlacingAlgorithm(int[] mapDimensions, Direction wall1, Direction wall2, params Furniture[] elements)
    {
        Walls = new Direction[] { wall1, wall2 };
        FurnitureToPlace = elements;
        Map = new int[mapDimensions[0], mapDimensions[1]];
    }


    public void Begin()
    {
        for (int i = 0; i < FurnitureToPlace.Length; i++)
        {
            Place(FurnitureToPlace[i]);
        }
    }

    //TODO: Create an algorithm responsible for furniture placement in given map
    private void Place(Furniture element)
    {
        for (int i = Map.GetLength(0); i > 0; i--)
        {
            for (int j = 0; j < Map.GetLength(1); j++)
            {
                if (Map[i,j] != 0)
                    continue;
            }
        }
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
