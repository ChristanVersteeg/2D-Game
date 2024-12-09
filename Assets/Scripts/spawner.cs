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
        int randomY = Random.Range(0,360);
        float randomScale = Random.Range(1, 4);
        GameObject spawnedObject = Instantiate(obstacle, new Vector2(randomX, transform.position.y), Quaternion.Euler(0, 0, randomY));
        spawnedObject.transform.localScale = Vector3.one * (randomScale / 10);
    }



     






}
