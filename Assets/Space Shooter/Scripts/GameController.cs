using UnityEngine;

public class GameController : MonoBehaviour
{
    public static float gameSpeed;
    public static bool hasReachedMax;
    private bool stop;


    private const float gameSpeedMax = 5;
    [SerializeField, Range(0, gameSpeedMax)] public float gameSpeedRegulator;
    [SerializeField] private float speedRate = 0.5f;

    private void Update()
    {
        if (stop) return;

        if (gameSpeedRegulator <= gameSpeedMax)
        {
            gameSpeedRegulator += speedRate * Time.deltaTime;
        }
        else
        {
            hasReachedMax = true;
        }
        gameSpeed = gameSpeedRegulator;
    }

    private void StopMovement(int _)
    {
        stop = true;
        gameSpeed = 0;
    }

    private void OnEnable()
    {
        Player.OnGameOver += StopMovement;
    }

    private void OnDisable()
    {
        Player.OnGameOver -= StopMovement;
    }
}