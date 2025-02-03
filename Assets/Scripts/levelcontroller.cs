using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    [SerializeField] Spawner spawner;
    public static int level;

    void Start()
    {

    }

    void Update()
    {
    }

    private void Victory()
    {
        level += 1;
    }

    private void Defeat()
    {
        level = 1;
        print("You have been defeated");
    }

    private void OnEnable()
    {
        Corn.OnCornDestroyed += Defeat;
    }

    private void OnDisable()
    {
        Corn.OnCornDestroyed -= Defeat;
    }
}
