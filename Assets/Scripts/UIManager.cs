using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI health, level, crystals;
    [SerializeField] private Text firerateCost, healthCost, damagecost;
    public int crystalCount;

    public void UpdateALLUI()
    {
        health.text = Corn.Instance.health.ToString();
        level.text = LevelController.level.ToString();
        crystals.text = crystalCount.ToString();
    }

    public void fireRateUpdateCost(int price)
    {
        firerateCost.text = price.ToString();
    }
    public void healthUpdateCost(int price)
    {
        healthCost.text = price.ToString();
    }
    public void DamageUpdateCost(int price)
    {
        damagecost.text = price.ToString();
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
