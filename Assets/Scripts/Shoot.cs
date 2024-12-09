using System.Collections;
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
        if (Input.GetKeyDown(KeyCode.Space) && !cooldown)
        {
            fire();
            StartCoroutine(nameof(ShootDelay));
        }
    }
   private void fire()
    {
        GameObject projectile = Instantiate(projectilePrefab, transform);
            projectile.transform.parent = bulletsParent;


    }



    private IEnumerator ShootDelay()
    {

        cooldown = true;
        yield return new WaitForSeconds(shootdelay);
        cooldown = false;

    }







}
