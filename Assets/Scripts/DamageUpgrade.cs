using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DamageUpgrade : MonoBehaviour
{
    [SerializeField] private UIManager manager;
    [SerializeField] private Button button;
    private int upgradePrice = 100;
    public static int damage = 1;

    private void BuyOnClick()
    {
        if (manager.crystalCount >= upgradePrice)
        {
            damage++;
            upgradePrice *= 2;
            manager.DamageUpdateCost(upgradePrice);
            manager.UpdateAllUI();
        }
    }

    private void OnEnable()
    {
        button.onClick.AddListener(BuyOnClick);
    }

    private void OnDisable()
    {
        button.onClick.RemoveListener(BuyOnClick);
    }
}
