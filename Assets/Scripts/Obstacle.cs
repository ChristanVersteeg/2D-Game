using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] private GameObject Effect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Destroy();
        }
    }


    public void Destroy()
    {
        GameObject effect = Instantiate(Effect, transform.position, Quaternion.identity);
        Destroy(effect, 3f);
        Destroy(gameObject);
    }


}
