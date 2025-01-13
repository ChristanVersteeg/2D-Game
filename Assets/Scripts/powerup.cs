using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tags;

public class powerup : MonoBehaviour
{

    private Shoot shoot;
    public bool fireRateBuff;
    public const int powerUpStrenght = 2;

    private void Awake()
    {
        shoot = GameObject.FindObjectOfType<Shoot>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       if( collision.CompareTag(Tag.Player))
        {
            shoot.shootdelay /= powerUpStrenght;
            shoot.StartBuff();
            Destroy(gameObject);
        }
    }
}
