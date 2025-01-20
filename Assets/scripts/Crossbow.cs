using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Crossbow : MonoBehaviour
{
    [SerializeField] private GameObject arrow;
    private bool cooldown;

    void Start()
    {
        
    }


    void Update()
    {
        Vector2 mouseposition = Input.mousePosition;
        Vector2 mousesceneposition = Camera.main.ScreenToWorldPoint(mouseposition);
        Vector2 difference = mousesceneposition - (Vector2)transform.position;

        float angle = Vector2.SignedAngle(Vector2.up, difference);

        transform.localEulerAngles = new(0, 0, angle); 


        if(Input.GetMouseButton(0))
            
        {
            if (!cooldown)
            {
                Instantiate(arrow, transform.position, transform.rotation);
                StartCoroutine(nameof(ShootCooldown));
            }
        }
    }



    private IEnumerator ShootCooldown()
    {
        cooldown = true;
        yield return new WaitForSeconds(0.5f);
        cooldown = false;
    }

}
