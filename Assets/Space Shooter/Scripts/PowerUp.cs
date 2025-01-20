using System.Collections;
using System.Collections.Generic;
using Tags;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    private Shoot shoot;
    public bool fireRateBuff;
    public const int powerUpStrength = 2;

    private void Awake()
    {
        shoot = FindObjectOfType<Shoot>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(Tag.Player))
        {
            shoot.shootDelay /= powerUpStrength;
            shoot.StartBuff();
            Destroy(gameObject);
        }
    }
}
