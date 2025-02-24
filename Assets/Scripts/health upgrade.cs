using UnityEngine;
using UnityEngine.UI;

public class Healthupgrade : MonoBehaviour
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
            manager.healthUpdateCost(upgradePrice);
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
