using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiddenBlock : MonoBehaviour
{
    [SerializeField] private BoxCollider2D boxColl;
    [SerializeField] private SpriteRenderer sprite;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (collision.transform.position.y + collision.GetComponent<BoxCollider2D>().size.y < gameObject.transform.position.y + boxColl.size.y)
            {
                sprite.enabled = true;
                boxColl.enabled = true;
                boxColl.usedByEffector = true;
            }
        }
    }
}
