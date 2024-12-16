using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static float gameSpeed;

     [Range(0, gameSpeedMax)]
     [SerializeField] private float gameSpeedRegulator;
     [SerializeField] private float speedRate = 0.5f;
     private const float gameSpeedMax = 3f;

    private void Update()
    {
        if (gameSpeedRegulator <= gameSpeedMax)
        {
            gameSpeedRegulator += speedRate * Time.deltaTime;
        }
        gameSpeed = gameSpeedRegulator;
    }




}
