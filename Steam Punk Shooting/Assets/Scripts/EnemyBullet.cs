using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    private PlayerBehaviour playerScript;
    private Vector2 targetPosition;
    public float speed;
    public int damage;
    public GameObject bulletExplosion;

    private void Start()
    {
        playerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerBehaviour>();
        targetPosition = playerScript.transform.position;
    }

    private void Update()
    {
        if(Vector2.Distance(transform.position, targetPosition) > .1f)
        {
            transform.position = Vector2.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
        }
        else{
            Destroy(gameObject);
            Instantiate(bulletExplosion, transform.position, Quaternion.identity);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            playerScript.TakeDamage(damage);
            Destroy(gameObject);
            Instantiate(bulletExplosion, transform.position, Quaternion.identity);
        }
    }
}
