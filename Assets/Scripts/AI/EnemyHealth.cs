using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float health;
    public float maxHealth = 100f;

    private void Start()
    {
        health = maxHealth;
    }

    void Update()
    {
        if(health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
