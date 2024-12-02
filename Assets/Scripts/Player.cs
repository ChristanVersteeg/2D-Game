using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int points;

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        Vector2 vector1 = Vector2.one;
        Vector2 vector2 = Vector2.one * 2;
        Vector2 vector3 = vector1 / vector2;

        if (Input.GetMouseButton(0))
        {
            Vector2 mousePos = Input.mousePosition;
            Vector2 cameraPos = Camera.main.ScreenToWorldPoint(mousePos);
            transform.position = cameraPos;
        }
    }
}
