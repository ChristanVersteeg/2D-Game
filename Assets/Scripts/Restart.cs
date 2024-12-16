using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Restart : MonoBehaviour
{
    private Button button;

    private void Awake()
    {
        button = GetComponent<Button>();
    }

    public void RestartScene()
    {
        SceneManager.LoadScene(0);
    }

    private void OnEnable()
    {
        button.onClick.AddListener(RestartScene);
    }

    private void OnDisable()
    {
        button.onClick.RemoveListener(RestartScene);
    }
}
