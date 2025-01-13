using System.Collections;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] private GameObject projectilePrefab;
    [SerializeField] private Transform bulletsParent;
    [SerializeField] private float shootDelay;
    private bool cooldown;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !cooldown)
        {
            Fire();
            StartCoroutine(nameof(ShootDelay));
        }
    }

    private void Fire()
    {
        GameObject projectile = Instantiate(projectilePrefab, transform);
        projectile.transform.parent = bulletsParent;
    }

    private IEnumerator ShootDelay()
    {
        cooldown = true;
        yield return new WaitForSeconds(shootDelay);
        cooldown = false;
    }
}