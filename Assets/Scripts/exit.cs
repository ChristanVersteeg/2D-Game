using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class exit : MonoBehaviour
{
    [SerializeField] private Button button;
    [SerializeField] private GameObject upgradePanel;


    private void exitpanel()
    {
        gameObject.SetActive(true);
    }

    private void OnEnable()
    {
        button.onClick.AddListener(exitpanel);
    }

    private void OnDisable()
    {
        button.onClick.RemoveListener(exitpanel);

    }
}
