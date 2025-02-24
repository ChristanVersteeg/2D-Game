using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthUpgrade : MonoBehaviour
{
    [SerializeField] private UIManager manager;
    [SerializeField] private Button button;
    private int upgradePrice = 100;

    private void BuyOnClick()
    {
        if (manager.crystalCount >= upgradePrice)
        {
            Corn.Instance.health += upgradePrice;
            upgradePrice *= 2;
            manager.HealthUpdateCost(upgradePrice);
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
