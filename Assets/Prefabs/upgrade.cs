using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class upgrade : MonoBehaviour
{
    [SerializeField] private Button button;
    [SerializeField] private GameObject upgradePanel;
   private void ShowUpgradePanelOnClick()
    {
      upgradePanel.SetActive(true);  
    }

    // Update is called once per frame
   private void OnEnable()
    {
        button.onClick.AddListener(ShowUpgradePanelOnClick);
    }

    private void OnDisable()
    {
        button.onClick.RemoveListener(ShowUpgradePanelOnClick);
    }
}
