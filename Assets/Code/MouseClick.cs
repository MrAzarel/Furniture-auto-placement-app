using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClick : MonoBehaviour
{
    private void OnMouseDown()
    {
        GameObject door = (GameObject)Instantiate(Resources.Load("Door"));
    }
}
