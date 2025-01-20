using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Crossbow : MonoBehaviour
{
    [SerializeField] private float fireRate;
    [SerializeField] private GameObject arrow;
    private bool cooldown;

    private void Start()
    {
    }

    private void Update()
    {
        Vector2 mousPosition = Input.mousePosition;
        Vector2 mouseScenePosition = Camera.main.ScreenToWorldPoint(mousPosition);
        Vector2 difference = mouseScenePosition - (Vector2)transform.position;

        float angle = Vector2.SignedAngle(Vector2.up, difference);

        transform.localEulerAngles = new(0, 0, angle);

        //print($"Screen: {mousPosition}, Scene: {mouseScenePosition}");

        if (Input.GetMouseButton(0))
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
        yield return new WaitForSeconds(fireRate);
        cooldown = false;
    }
}
