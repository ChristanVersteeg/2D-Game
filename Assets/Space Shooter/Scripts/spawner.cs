using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Random = UnityEngine.Random;
using System.Runtime.InteropServices.WindowsRuntime;

public class Spawner : MonoBehaviour

{
    [SerializeField] private GameObject obstacle, item, powerUp, shieldBuff;
    [SerializeField] private Transform leftborder, rightborder;

    private void Start()
    {
        StartCoroutine(nameof(Delay));
        StartCoroutine(nameof(powerUpDelay));
        StartCoroutine(nameof(ShieldDelay));

    }

    private IEnumerator Delay()
    {
        while (true)
        {
            spawn();
            yield return new WaitForSeconds(1);
        }

    }

    private IEnumerator powerUpDelay()
    {
        while (true)
        {
            spawn(true, powerUp);
            yield return new WaitForSeconds(30);
        }

    }

    private IEnumerator ShieldDelay()
    {
        while (true)
        {
            spawn(true, shieldBuff);
            yield return new WaitForSeconds(40);
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

    private void spawn(bool isPowerUp = false, GameObject powerup = null)
    {
        float randomX = Random.Range(leftborder.position.x, rightborder.position.x);
        int randomY = Random.Range(0, 360);
        float randomScale = Random.Range(2, 4);

        if (isPowerUp)
        {
            Instantiate(powerup, new Vector2(randomX, transform.position.y), Quaternion.identity);
        }
        else
        {
            GameObject spawnedObject = Instantiate(ReturnRandomObject(), new Vector2(randomX, transform.position.y), Quaternion.Euler(0, 0, randomY));
            spawnedObject.transform.localScale = Vector3.one * (randomScale / 10);
        }
        

       

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