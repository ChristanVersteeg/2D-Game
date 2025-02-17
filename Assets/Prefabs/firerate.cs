using UnityEngine;
using UnityEngine.UI;

public class firerate : MonoBehaviour
{
    [SerializeField] private crossbow crossbow;
    [SerializeField] private UIManager manager;
    [SerializeField] private Button button;

    private void BuyOnClick()
    {
        if (manager.crystalCount >= 100)
        {
            crossbow.fireRate /= 2;
            manager.crystalCount -= 100;
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