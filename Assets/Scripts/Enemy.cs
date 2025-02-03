using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int health;
    [SerializeField] private float speed;
    [SerializeField] private float attackCooldown;
    private bool attackState;

    public void TakeDamage()
    {
        health -= 1;

        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

    private IEnumerator Attack()
    {
        while (true)
        {
            Corn.Instance.TakeDamage();
            yield return new WaitForSeconds(attackCooldown);
        }
    }

    private void Update()
    {
        if (transform.position.x > Corn.Instance.transform.position.x)
        {
            transform.position += -transform.right * speed * Time.deltaTime;
        }
        else if (!attackState)
        {
            attackState = true;
            StartCoroutine(Attack());
        }
    }
}