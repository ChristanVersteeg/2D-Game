using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Algo
{

    public class Obstacle : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if(collision.tag == "Player")
            {
                Destroy(collision.gameObject);
            }
        }
    }
}