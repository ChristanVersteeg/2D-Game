using UnityEngine;

public class LevelController : MonoBehaviour
{
    [SerializeField] private Spawner spawner;
    public static int level;

    private void Start()
    {

    }

    private void Update()
    {

    }

    private void Victory()
    {
        level += 1;
    }

    private void Defeat()
    {
        level = 1;
        print("You have been defeated");
    }

    private void OnEnable()
    {
        Corn.OnCornDestroyed += Defeat;
    }

    private void OnDisable()
    {
        Corn.OnCornDestroyed -= Defeat;
    }
}
