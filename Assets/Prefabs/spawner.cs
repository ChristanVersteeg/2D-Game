using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class spawner : MonoBehaviour
{
    [SerializeField] private Transform topBorder, bottomBorder;
    [SerializeField] private GameObject Enemy;
    [SerializeField] private float minSpawnTime, maxSpawnTime;
    [SerializeField] private int maxSpawnCount;
    // Start is called before the first frame update
    private void Start()
    {
        StartCoroutine(Spawn());
    }

    // Update is called once per frame
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
            Instantiate(Enemy, new Vector3(transform.position.x, randY, 0), Quaternion.identity);
            spawnCount++;
        }
    }
}


