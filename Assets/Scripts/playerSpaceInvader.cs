using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class playerSpaceInvader : MonoBehaviour
{
    public int points;

    void Start()
    {
        
    }
 
    void Update()
    {
        move();
    }

    private void move()

    {
        if (Input.GetMouseButton(0))
        {

            Vector2 mousePos = Input.mousePosition;
            Vector2 camerapos = Camera.main.ScreenToWorldPoint(mousePos);
            transform.position = camerapos;
        }






    }
}
