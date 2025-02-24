using UnityEngine;
using UnityEngine.UI;

public class FireRate : MonoBehaviour
{
    [SerializeField] private Crossbow crossbow;
    [SerializeField] private UIManager manager;
    [SerializeField] private Button button;
    private int upgradePrice = 100;

    private void BuyOnClick()
    {
        if (manager.crystalCount >= upgradePrice)
        {
            crossbow.fireRate /= 2;
            manager.crystalCount -= upgradePrice;
            upgradePrice *= 2;
            manager.fireRateUpdateCost(upgradePrice);
            manager.UpdateALLUI();
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
