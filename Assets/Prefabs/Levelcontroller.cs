using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levelcontroller : MonoBehaviour
{
    [SerializeField] spawner spawner;
    public static int level;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Victory()
    {
        level += 1;
        print("Victory zawg");
        spawner.StartSpawning();
    }

    private void Defeat()
    {
        level = 1;
        print("get clapped lil bro");
    }

    private void OnEnable()
    {
        Corn.OnCornDestroyed += Defeat;
        Enemy.OnLastEnemyKilled += Victory;
    }

    private void OnDisable()
    {
        Corn.OnCornDestroyed -= Defeat;
        Enemy.OnLastEnemyKilled -= Victory;
    }
}

