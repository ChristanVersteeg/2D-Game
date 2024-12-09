using System.Collections;
using System.Runtime.CompilerServices;
using Unity.IO.LowLevel.Unsafe;
using Unity.VisualScripting;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] private GameObject projectilePrefab;
    [SerializeField] private Transform bulletsParent;
    [SerializeField] private float shootdelay;
    private bool cooldown;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))

            if (!cooldown)
            {
                fire();
                StartCoroutine(nameof(shootDelay));


            }
    }



    private void fire()
    {
        GameObject projectile = Instantiate(projectilePrefab, transform);
        projectile.transform.parent = bulletsParent;
    }


    private IEnumerator shootDelay()

    {
        cooldown = true;
        yield return new WaitForSeconds(shootdelay);
        cooldown = false;
    }
}