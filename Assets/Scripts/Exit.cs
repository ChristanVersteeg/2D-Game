using UnityEngine;
using UnityEngine.UI;

public class Exit : MonoBehaviour
{
    [SerializeField] private Button button;

    private void ExitPanel()
    {
        gameObject.SetActive(true);
    }

    private void OnEnable()
    {
        button.onClick.AddListener(ExitPanel);
    }

    private void OnDisable()
    {
        button.onClick.RemoveListener(ExitPanel);
    }
}