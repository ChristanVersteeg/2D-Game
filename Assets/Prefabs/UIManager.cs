using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Runtime.CompilerServices;
using Microsoft.Win32.SafeHandles;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI health, level, crystals;
    private int healthCount, levelCount, crystalCount;


    private void DecrementHealth()
    {
        health.text = Corn.Instance.health.ToString();
    }

    private void IncermentLevel()
    {
        levelCount--;
        level.text = Levelcontroller.level.ToString();
    }

    private void Incermentcrystals()
    {
        crystalCount += 5;
        crystals.text = crystalCount.ToString(); 
    }

    private void OnEnable() 
    {
        Enemy.OnEnemyKilled += Incermentcrystals;
        Enemy.OnLastEnemyKilled += IncermentLevel;
        Enemy.OnEnemyAttacked += DecrementHealth;
    }

    private void  OnDisable()
    {
        Enemy.OnEnemyKilled += Incermentcrystals;
        Enemy.OnLastEnemyKilled += IncermentLevel;
        Enemy.OnEnemyAttacked += DecrementHealth;
    }
    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
