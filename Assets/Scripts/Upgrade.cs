using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class Upgrade : MonoBehaviour
{ 
    [SerializeField] private Button button;
    [SerializeField] private GameObject upgradePanel;


private void showupgradepanelonclick()
{
upgradePanel.SetActive(true);
}

private void OnEnable()
{
    button.onClick.AddListener(showupgradepanelonclick);
}

    private void OnDisable()
    {
        button.onClick.RemoveListener(showupgradepanelonclick);

    }
}