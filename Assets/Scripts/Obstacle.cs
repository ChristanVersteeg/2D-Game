using Tags;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Obstacle : MonoBehaviour
{
    [SerializeField] private GameObject effect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(Tag.Player))
        {
            //SceneManager.LoadScene(0);
            Destroy();
        }
    }

    public void Destroy()
    {
        GameObject tempEffect = Instantiate(effect, transform.position, Quaternion.identity);
        Destroy(tempEffect, 3f);
        Destroy(gameObject);
    }
}
