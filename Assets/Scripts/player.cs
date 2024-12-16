using System;
using System.Collections;
using System.Collections.Generic;
using Tags;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int points;
    [SerializeField] private Canvas UI;
    public static event Action<int> OnGameOver;
   
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


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(Tag.Obstacle))
        {
            UI.enabled = true;
            OnGameOver(points);

        }
    }

}
