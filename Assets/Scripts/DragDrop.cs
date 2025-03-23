using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragDrop : MonoBehaviour
{
    private Vector3 offset;
    private bool isDragging = false;

    void OnMouseDown()
    {
        offset = transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
        isDragging = true;
    }

    void OnMouseDrag()
    {
        if (isDragging)
        {
            Vector3 newPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) + offset;
            newPosition.z = 0; 
            transform.position = newPosition;
        }
    }

    void OnMouseUp()
    {
        isDragging = false;

       
        float gridX = Mathf.Round(transform.position.x);
        float gridY = Mathf.Round(transform.position.y);

        transform.position = new Vector3(gridX, gridY, 0);

       // GameManager gameManager = FindObjectOfType<GameManager>();
        //gameManager.CheckWin();

    }

}
