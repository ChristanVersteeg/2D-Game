using System.Collections;
using System.Collections.Generic;
using Tags;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] public float speed;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(Tag.OutOfBounds))
        {
            Destroy(gameObject);
        }
    }

    void Update()
    {
        transform.position = (Vector2)transform.position + Vector2.down * speed * Time.deltaTime * GameController.gameSpeed;
    }
}
