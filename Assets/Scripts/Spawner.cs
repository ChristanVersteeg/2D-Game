using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject obstacle, item;

    [SerializeField] private Transform leftBorder, rightBorder;

    private void Start()
    {
        StartCoroutine(nameof(Delay));
    }

    private IEnumerator Delay()
    {
        while (true)
        {
            Spawn();
            yield return new WaitForSeconds(1);
        }
    }

    private void Spawn()
    {
        float randomX = Random.Range(leftBorder.position.x, rightBorder.position.x);

        Instantiate(obstacle, new Vector2(randomX, transform.position.y), Quaternion.identity);
    }
}