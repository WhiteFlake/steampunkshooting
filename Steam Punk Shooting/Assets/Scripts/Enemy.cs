using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health;

    [HideInInspector]
    public Transform player;
    [HideInInspector]
    public float distance;
    [HideInInspector]
    public bool facinRight;

    public float speed;
    public float timeBetweenAttacks;
    public int damage;
    

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        facinRight = true;
    }

    public void TakeDamage(int damageAmount)
    {
        health -= damageAmount;

        if(health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
