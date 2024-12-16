using System;
using Tags;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int points;
    [SerializeField] private Canvas UI;
    public static event Action<int> OnGameOver;

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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(Tag.Obstacle))
        {
            UI.enabled = true;
            OnGameOver(points);
        }
    }
}
