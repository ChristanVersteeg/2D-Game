using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int health;
    [SerializeField] private float speed;
    [SerializeField] private float attackCooldown;
    private bool attackState;
    public static event Action OnLastEnemyKilled, OnEnemyKilled, OnEnemyAttack;
    public static List<GameObject> enemies = new();

    private void Start()
    {
        enemies.Add(gameObject);
    }

    public void TakeDamage()
    {
        health -= 1;

        if (health <= 0)
        {
            if (Spawner.allEnemiesSpawned && enemies.Count == 1)
            {
                OnLastEnemyKilled();
            }
            enemies.Remove(gameObject);
            OnEnemyKilled();
            Destroy(gameObject);
        }
    }

    private IEnumerator Attack()
    {
        while (true)
        {
            Corn.Instance.TakeDamage();
            OnEnemyAttack();
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