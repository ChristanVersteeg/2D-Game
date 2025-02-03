using UnityEngine;

public class Arrow : MonoBehaviour
{
    public float speed;

    private void Start()
    {
        Destroy(gameObject, 3);
    }

    private void Update()
    {
        transform.position += speed * Time.deltaTime * transform.up;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            collision.GetComponent<Enemy>().TakeDamage();
            Destroy(gameObject);
        }
    }
}