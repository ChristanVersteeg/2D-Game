using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int points;

    void Update()
    {
        Move();
    }

    private void Move()
    {
        if (Input.GetMouseButton(0))
        {
            Vector2 mousePos = Input.mousePosition;
            Vector2 cameraPos = Camera.main.ScreenToWorldPoint(mousePos);
            transform.position = cameraPos;
        }
    }
}
