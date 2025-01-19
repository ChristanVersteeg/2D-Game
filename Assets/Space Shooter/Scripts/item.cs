using UnityEngine;
using Tags;
using UnityEngine.Timeline;

public class Item : MonoBehaviour
{
    [SerializeField] private GameObject Effect;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Player player = collision.GetComponent<Player>();
            player.points++;

            GameObject effect = Instantiate(Effect, transform.position, Quaternion.identity);
            Destroy(effect, 3f);

            Destroy(gameObject);
        }
    }
}
