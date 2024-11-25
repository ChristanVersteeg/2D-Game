using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D Collision)
    {
        if (Collision.CompareTag("Player"))
        {
            playerSpaceInvader player = Collision.GetComponent<playerSpaceInvader>();
            player.points++;
            Destroy(gameObject);


        }


    }
}
