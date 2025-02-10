using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI health, level, crystals;
    private int crystalCount;

    private void DecrementHealth()
    {
        health.text = Corn.Instance.health.ToString();
    }

    private void IncrementLevel()
    {
        level.text = LevelController.level.ToString();
    }

    private void IncrementCrystals()
    {
        crystalCount += 5;
        crystals.text = crystalCount.ToString();
    }

    private void OnEnable()
    {
        Enemy.OnEnemyKilled += IncrementCrystals;
        Enemy.OnLastEnemyKilled += IncrementLevel;
        Enemy.OnEnemyAttack += DecrementHealth;
    }

    private void OnDisable()
    {
        Enemy.OnEnemyKilled -= IncrementCrystals;
        Enemy.OnLastEnemyKilled -= IncrementLevel;
        Enemy.OnEnemyAttack -= DecrementHealth;
    }
}
