using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class Square : MonoBehaviour
{
    [SerializeField] private Vector2 targetposition;

    [SerializeField ] private bool isTrap;

    [SerializeField] private float stepLength;


    private Vector2 RandomisVector()
    {
        Vector2 randomVector;
        randomVector.x = Random.Range(-6, 6);
        randomVector.y = Random.Range(-3, 3);

        return randomVector;
    }


   
    private void Start()
    {
        targetposition = RandomisVector(); 

        if(!isTrap)
        {
            player.squares.Add(this);

        }
    }

   
    private void Update()
    {
       transform.position = Vector2.MoveTowards(transform.position, targetposition, stepLength * Time.deltaTime);

        if ((Vector2)transform.position == targetposition)
        {
         
            targetposition = RandomisVector();

        }


    }
    

    private void Catch()
    {
        player.score++;

    }


    private void OnMouseDown()
    {
        if (isTrap)
        {
            player.Defeat();
        }
        else Catch();

    }

}
