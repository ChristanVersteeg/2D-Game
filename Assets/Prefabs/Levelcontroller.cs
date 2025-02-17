using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levelcontroller : MonoBehaviour

{
    [SerializeField] spawner spawner;
    [SerializeField] private GameObject passed, defeat;
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
        passed.SetActive(true);
    }

    private void Defeat()
    {
        level = 1;
        print("get clapped lil bro");
        defeat.SetActive(true);
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

