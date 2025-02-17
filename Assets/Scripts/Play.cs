using UnityEngine;
using UnityEngine.UI;

public class Play : MonoBehaviour
{
    [SerializeField] private Button button;
    [SerializeField] private Spawner spawner;

    private void PlayOnClick()
    {
        transform.parent.gameObject.SetActive(false);
        spawner.StartSpawning();
    }

    private void OnEnable()
    {
        button.onClick.AddListener(PlayOnClick);
    }

    private void OnDisable()
    {
        button.onClick.RemoveListener(PlayOnClick);
    }
}
