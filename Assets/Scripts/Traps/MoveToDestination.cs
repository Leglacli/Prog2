using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToDestination : MonoBehaviour
{
    [SerializeField] private GameObject gameOb;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float speed;
    private bool attacked = false;



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && !attacked)
        {
            if (transform.position.x == gameOb.transform.position.x)
            {
                if (transform.position.y - gameOb.transform.position.y > 0.1f)
                {
                    rb.velocity = new Vector2(rb.velocity.x, speed);
                }
                else
                {
                    rb.velocity = new Vector2(rb.velocity.x, -speed);
                }
            }
            else if (transform.position.y == gameOb.transform.position.y)
            {
                if (transform.position.x - gameOb.transform.position.x > 0.1f)
                {
                    rb.velocity = new Vector2(speed, rb.velocity.y);
                }
                else
                {
                    rb.velocity = new Vector2(-speed, rb.velocity.y);
                }
            }
            attacked = true;
            Destroy(gameOb.gameObject, 2f);
        }
    }
}
