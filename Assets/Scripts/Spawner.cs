using System.Collections;
using Unity.VisualScripting;
using UnityEditor.Timeline;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Transform topBorder, bottomBorder;
    [SerializeField] private GameObject enemy;
    [SerializeField] private float minSpawnTime, maxSpawnTime;
    [SerializeField] private int maxSpawnCount;
    [SerializeField] private int maxSpawnAddPerLevel;
    public static bool allEnemiesSpawned;

    public void StartSpawning()
    {
        StartCoroutine(Spawn());
    }

    private void Start()
    {
        StartSpawning();
    }

    private void Update()
    {

    }

    private IEnumerator Spawn()
    {
        maxSpawnCount += maxSpawnAddPerLevel * LevelController.level;

        int spawnCount = 0;

        allEnemiesSpawned = false;

        while (spawnCount < maxSpawnCount)
        {
            float randSpawnTime = Random.Range(minSpawnTime, maxSpawnTime);
            yield return new WaitForSeconds(randSpawnTime);
            float randY = Random.Range(bottomBorder.position.y, topBorder.position.y);
            Instantiate(enemy, new Vector3(transform.position.x, randY, 0), Quaternion.identity);
            spawnCount++;
        }

        allEnemiesSpawned = true;
    }
}