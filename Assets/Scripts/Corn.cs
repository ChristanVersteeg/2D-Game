using System;
using UnityEngine;

public class Corn : MonoBehaviour
{
    public static Action OnCornDestroyed;
    public static Corn Instance;
    [SerializeField] private int health;
    [SerializeField] private GameObject cornField;

    private void Awake()
    {
        Instance = this;
    }

    public void TakeDamage()
    {
        health -= 1;

        if (health <= 0)
        {
            Destroy(cornField);
            transform.position = Vector3.one * -1000;
            OnCornDestroyed();
        }
    }
}