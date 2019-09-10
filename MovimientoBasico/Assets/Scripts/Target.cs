using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
   float tx = 10;
   float ty = 20;
   float minX = -5;
   float minY = -5;
   float width = 10;
   float height = 10;


    void Update()
    {
         Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.Scale(new Vector3(1, 1, 0));
        transform.position = mousePosition; 
    }
}
