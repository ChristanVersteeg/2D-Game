using Tags;
using UnityEngine;
using UnityEngine.Timeline;

public class Item : MonoBehaviour
{
    [SerializeField] private GameObject effect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(Tag.Player))
        {
            Player player = collision.GetComponent<Player>();
            player.points++;

            GameObject tempEffect = Instantiate(effect, transform.position, Quaternion.identity);
            Destroy(tempEffect, 3f);

            Destroy(gameObject);
        }
    }
}
