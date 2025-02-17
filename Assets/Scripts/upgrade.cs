using UnityEngine;
using UnityEngine.UI;

public class Upgrade : MonoBehaviour
{
    [SerializeField] private Button button;
    [SerializeField] private GameObject upgradePanel;

    private void ShowUpgradePanelOnClick()
    {
        upgradePanel.SetActive(true);
    }

    private void OnEnable()
    {
        button.onClick.AddListener(ShowUpgradePanelOnClick);
    }

    private void OnDisable()
    {
        button.onClick.RemoveListener(ShowUpgradePanelOnClick);
    }
}
