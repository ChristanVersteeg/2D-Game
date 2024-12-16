using UnityEngine;

public class GameController : MonoBehaviour
{
    public static float gameSpeed;
    public static bool hasReachedMax;

    private const float gameSpeedMax = 5;
    [SerializeField, Range(0, gameSpeedMax)] public float gameSpeedRegulator;
    [SerializeField] private float speedRate = 0.5f;

    private void Update()
    {
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
}