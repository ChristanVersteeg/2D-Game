using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    [SerializeField] private Spawner spawner;
    [SerializeField] private GameObject Passed, defeat;
    public static int level;

    private void Start()
    {

    }

    private void Update()
    {
    }

    private void Victory()
    {
        level += 1;
        print("You won the level!");
        Passed.SetActive(true);
    }

    private void Defeat()
    {
        level = 1;
        print("You have been defeated!");
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
