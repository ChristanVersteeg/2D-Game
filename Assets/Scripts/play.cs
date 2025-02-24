using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class play : MonoBehaviour
{

    [SerializeField] private Button button;
    [SerializeField] private Spawner spawner;


    private void playonclick()
    {
        transform.parent.gameObject.SetActive(false);
        spawner.StartSpawning();

    }

    private void OnEnable()
    {
        button.onClick.AddListener(playonclick); 
    }

    private void OnDisable()
    {
        button.onClick.RemoveListener(playonclick);
    }
}
