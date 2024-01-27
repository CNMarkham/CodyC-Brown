using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float yForce;

    private Rigidbody2D enemyRigidbody;

    private void Start()
    {
        enemyRigidbody = GetComponent<Rigidbody2D>();

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            Vector2 jumpForce = new Vector2(0, yForce);
            enemyRigidbody.AddForce(jumpForce);
        }
    }
    private void FixedUpdate()
    {
        if (transform.position.x <= -8)
        {
            
        }
        if (transform.position.x >= 8)
        {
            
        }

    }
}
