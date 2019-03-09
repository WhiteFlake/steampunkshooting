using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRanged: Enemy
{
    public float stopDistance;
    private float attackTime;
    public Transform gun;
    public Transform shotPoint;
    public GameObject enemyBullet;
    private Quaternion bulletRotation;
    public GameObject explosion;


    private void Update()
    {
        if (player != null)
        {
            if (Vector2.Distance(transform.position, player.position) > stopDistance)
            {
                transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
            }

            Vector2 direction = player.position - gun.position;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            Quaternion rotation = Quaternion.AngleAxis(angle + 60, Vector3.forward);
            Quaternion bulletRotation = Quaternion.AngleAxis(angle - 90, Vector3.forward);
            gun.rotation = rotation;

            if (Time.time >= attackTime)
            {
                attackTime = Time.time + timeBetweenAttacks;
                Instantiate(enemyBullet, shotPoint.position, bulletRotation);
                Instantiate(explosion, shotPoint.position, Quaternion.identity);
            }
        }
    }
}
