using System.Collections;
using System.Collections.Generic;
using Tags ;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] public float speed;

    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if (collision.compareTag(Tag.OutofBounds))  
         {
             Destroy(gameObject);
         }
    }       
        
}
   private void Update()
    {
        transform.position = (Vector2)transform.position + Vector2.down * speed * Time.deltaTime;
    }
}
