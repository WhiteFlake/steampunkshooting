using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMelee : Enemy
{
    public float stopDistance;

    private void Update()
    {
       if(player != null)
        {
            if(Vector2.Distance(transform.position, player.position) > stopDistance)
            {
                transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
                distance = player.position.x - transform.position.x;
                Flip(distance);
            }
        }
    }

    public void Flip(float distance)
    {
        if (distance >= 0 && !facinRight || distance < 0 && facinRight)
        {
            facinRight = !facinRight;
            Vector3 scale = transform.localScale;
            scale.x *= -1;
            transform.localScale = scale;
        }
    }
}
