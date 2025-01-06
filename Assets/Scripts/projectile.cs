using Tags;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(Tag.Obstacle))
        {
            Obstacle obstacle = collision.GetComponent<Obstacle>();
            obstacle.Destroy();
            Destroy(gameObject);
        }
    }
}
