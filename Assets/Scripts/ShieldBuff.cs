using System;
using System.Collections;
using System.Collections.Generic;
using Tags;
using UnityEngine;

public class ShieldBuff : MonoBehaviour

{
 
    
    public static bool shielded;


    private void RevokeShield()
    {
        shielded = false;
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(Tag.Player)) ;
        {
            shielded = true ;
            transform.parent = collision.transform;
            Destroy(GetComponent<Mover>());
            Destroy(GetComponent<BoxCollider2D>());
            Invoke(nameof(RevokeShield), 7);
        }
    }
}
