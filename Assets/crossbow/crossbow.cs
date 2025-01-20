using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class crossbow : MonoBehaviour
{
    [SerializeField] private GameObject arrow;
    private bool cooldown;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mouseScreenPos = Input.mousePosition;
        Vector2 mouseScenePos = Camera.main.ScreenToWorldPoint(mouseScreenPos);
        Vector2 difference = mouseScenePos - (Vector2)transform.position;


        float angle = Vector2.SignedAngle(Vector2.up, difference);

        transform.localEulerAngles = new(0, 0, angle);
        if (Input.GetMouseButton(0))
        {
            if (!cooldown) { 
          
                Instantiate(arrow, transform.position, transform.rotation);
                StartCoroutine(nameof(Shootcooldown));
            }
        }

    }


    private IEnumerator Shootcooldown()
    {
        cooldown = true;
        yield return new WaitForSeconds(0.5f);
        cooldown = false;
    }
}
