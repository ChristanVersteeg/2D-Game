using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI health, level, crystals;
    [SerializeField] private Text fireRateCost, healthCost, damageCost;
    public int crystalCount;

    public void UpdateAllUI()
    {
        health.text = Corn.Instance.health.ToString();
        level.text = LevelController.level.ToString();
        crystals.text = crystalCount.ToString();
    }

    public void FireRateUpdateCost(int price)
    {
        fireRateCost.text = price.ToString();
    }

    public void HealthUpdateCost(int price)
    {
        healthCost.text = price.ToString();
    }

    public void DamageUpdateCost(int price)
    {
        damageCost.text = price.ToString();
    }

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
