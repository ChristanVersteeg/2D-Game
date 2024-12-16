using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Random = UnityEngine.Random;
using System.Runtime.InteropServices.WindowsRuntime;

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
            float delay = 1;
            if(GameController.hasReachedMax)
            {
                delay = 0.5f;
            }
            spawn();
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
    private void spawn()
    {
        float randomX = Random.Range(leftborder.position.x, rightborder.position.x);
        int randomY = Random.Range(0, 360);
        float randomScale = Random.Range(2, 4);
       
        GameObject spawnedObject = Instantiate(ReturnRandomObject(), new Vector2(randomX, transform.position.y), Quaternion.Euler(0, 0, randomY));
        spawnedObject.transform.localScale = Vector3.one * (randomScale / 10);
    }
}