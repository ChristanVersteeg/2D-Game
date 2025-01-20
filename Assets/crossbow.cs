using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class crossbow : MonoBehaviour
{
    [SerializeField] private GameObject arrow;
    private bool cooldown;
    void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {
        Vector2 mousposition = Input.mousePosition;
        Vector2 mouseceneposition = Camera.main.ScreenToWorldPoint(mousposition);
        Vector2 difference = mouseceneposition - (Vector2)transform.position;

        float angle = Vector2.SignedAngle(Vector2.up, difference);
        transform.eulerAngles = new(0, 0, angle);


        if (Input.GetMouseButton(0)) ;

        if (!cooldown)  
        {
            Instantiate(arrow, transform.position, transform.rotation);
            StartCoroutine(nameof(ShootCooldown));
            

        }
    }
    
  
private IEnumerator ShootCooldown()
{
    cooldown = true;
    yield return new WaitForSeconds(0.5f);
    cooldown = false;
}
}