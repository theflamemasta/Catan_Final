using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrapDrop : MonoBehaviour
{
    private bool isDragging = false;
    private Vector2 startPosition;

    private void Update()
    {
        if (isDragging)
        {
            transform.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        }
    }

    public void StartDrag()
    {
        startPosition = transform.position;
        isDragging = true;
    }

    public void EndDrag()
    {
        isDragging = false;
    }
}
