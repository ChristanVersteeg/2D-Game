using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
public class spawner : MonoBehaviour
{
    [SerializeField] private GameObject obstacle, item;
    [SerializeField] private Transform leftborder, rightborder;
    private void Start()
    {
        StartCoroutine(nameof(delay));
    }
    private IEnumerator delay()
    {
        {
            while (true)
            {
                Spawn();
                yield return new WaitForSeconds(1);
            }
        }
    }

    private void Spawn()
        {
            float randomX = Random.Range(leftborder.position.x, rightborder.position.x);

            Instantiate(obstacle, new Vector2(randomX, transform.position.y), Quaternion.identity);
        }
    }
