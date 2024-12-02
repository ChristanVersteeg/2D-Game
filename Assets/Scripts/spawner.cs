using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour

{
    [SerializeField] private GameObject obstacle, item;
    [SerializeField] private Transform leftborder, rightborder;

    private void Start()
    {
        StartCoroutine(nameof(Delay));
    }


    private IEnumerator Delay()
    {
        while (true)
        {
            spawn();
            yield return new WaitForSeconds(1);
        }
    }
    private void spawn()
    {
        float randomX = Random.Range(leftborder.position.x, rightborder.position.x);
        Instantiate(obstacle, new Vector2(randomX, transform.position.y), Quaternion.identity);

    }










}
