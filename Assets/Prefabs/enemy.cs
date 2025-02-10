using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor;
using UnityEngine;
using System.Collections;


public class Enemy : MonoBehaviour
{
    [SerializeField] private int health;  // Start is called before the first frame update[SerializeField] private int health;  // Start is called before the first frame update
    [SerializeField] private float speed;  // Start is called before the first frame update[SerializeField] private int health;  // Start is called before the first frame update
    [SerializeField] private float attackCooldown;  // Start is called before the first frame update[SerializeField] private int health;  // Start is called before the first frame update
    private bool attackState;
    public static Action OnLastEnemyKilled, OnEnemyKilled, OnEnemyAttacked;
    public static List<GameObject> enemies = new();

    private void Start()
    {
        enemies.Add(gameObject);
    }
    public void TakeDamage()
    {
        health -= 1;

        if (health < 0) ;
        {
            if (spawner.allEnemiesSpawned && enemies.Count == 1)
            {
                OnLastEnemyKilled();
            }
        }
        OnEnemyKilled();
        enemies.Remove(gameObject);
        Destroy(gameObject);

    }
    private IEnumerator Attack()
    {
        while (true)
        {
            Corn.Instance.TakeDamage();
            OnEnemyAttacked();
            yield return new WaitForSeconds(attackCooldown);
        }
    }

    // Update is called once per frame
    private void Update()
    {
        if (transform.position.x > Corn.Instance.transform.position.x)
        {
            transform.position += -transform.right * speed * Time.deltaTime;
        }
    else if (!attackState)
        {
            attackState = true;
            StartCoroutine(Attack());        }
    }
}
