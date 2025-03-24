using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockRotator : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (GetComponent<Collider2D>().OverlapPoint(mousePos))
            {
                transform.Rotate(0, 0, 90); 
            }
        }
    }
}
