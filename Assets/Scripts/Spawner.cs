using System;
using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

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
            float delay = 1;
            if (GameController.hasReachedMax)
            {
                delay = 0.5f;
            }
            Spawn();
            yield return new WaitForSeconds(delay);
        }
    }

    private GameObject ReturnRandomObject()
    {
        int randomObjectIndex = Random.Range(0, 3);
        GameObject randomObject;
        if (randomObjectIndex <= 1)
        {
            randomObject = obstacle;
        }
        else
        {
            randomObject = item;
        }
        return randomObject;
    }

    private void Spawn()
    {
        float randomX = Random.Range(leftBorder.position.x, rightBorder.position.x);
        int randomRotation = Random.Range(0, 360);
        float randomScale = Random.Range(1, 4);

        GameObject spawnedObject = Instantiate(ReturnRandomObject(), new Vector2(randomX, transform.position.y), Quaternion.Euler(0, 0, randomRotation));
        spawnedObject.transform.localScale = Vector3.one * (randomScale / 10);
    }

    private void DeleteSpawner(int _)
    {
        Destroy(gameObject);
    }

    private void OnEnable()
    {
        Player.OnGameOver += DeleteSpawner;
    }

    private void OnDisable()
    {
        Player.OnGameOver -= DeleteSpawner;
    }
}