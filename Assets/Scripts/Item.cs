using UnityEngine;
using UnityEngine.Timeline;

public class Item : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Player player = collision.GetComponent<Player>();
            player.points++;
            Destroy(gameObject);
        }
    }
}
