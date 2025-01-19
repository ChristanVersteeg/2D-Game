using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static float gameSpeed;
    private bool stop;
     [Range(0, gameSpeedMax)]
     [SerializeField] private float gameSpeedRegulator;
     [SerializeField] private float speedRate = 0.5f;
     private const float gameSpeedMax = 3f;

    private void Update()
    {
        if (stop) return;


        if (gameSpeedRegulator <= gameSpeedMax)
        {
            gameSpeedRegulator += speedRate * Time.deltaTime;
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
