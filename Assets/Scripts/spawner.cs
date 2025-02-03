using System.Collections;
using System.Collections.Generic;
using Unity.Properties;
using UnityEngine;

public class spawner : MonoBehaviour
{
    [SerializeField] private GameObject enemy;
    [SerializeField] private Transform Topborder, BottomBorder;
    [SerializeField] private float minspawntime, maxspawntime;
    [SerializeField] private int maxspawncount;
    private void Start()
    {
        StartCoroutine(spawn());
    }


    private void Update()
    {

    }

    private IEnumerator spawn()
    {
        int spawncount = 0; 

        while (spawncount < maxspawntime)
        {

            float randspawntime = Random.Range(minspawntime, maxspawntime);
            yield return new WaitForSeconds(randspawntime);
            float randy = Random.Range(BottomBorder.position.y, Topborder.position.y);
            Instantiate(enemy, new Vector3(transform.position.x, randy, 0), Quaternion.identity);
            spawncount++;
        }
    }
}