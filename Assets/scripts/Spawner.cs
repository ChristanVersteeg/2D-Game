using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Transform topBorder, bottomBorder;
    [SerializeField] private GameObject enemy;
    [SerializeField] private float minSpawnTime, maxSpawnTime;
    [SerializeField] private int maxSpawnCount;



    private void Start()
    {
        StartCoroutine(Spawn());
    }

    private void Update()
    {
        
    }

    private IEnumerator Spawn()
    {
        int spawnCount = 0;
        while (spawnCount < maxSpawnCount)
        {
            float randSpawnTime = Random.Range(minSpawnTime, maxSpawnTime);
            yield return new WaitForSeconds(randSpawnTime);
            float randY = Random.Range(bottomBorder.position.y, topBorder.position.y);
            Instantiate(enemy, new Vector3(transform.position.x, randY, 0), Quaternion.identity);
            spawnCount++;
        }
    }
}
