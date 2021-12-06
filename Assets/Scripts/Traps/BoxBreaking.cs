using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxBreaking : MonoBehaviour
{
    [SerializeField] private float destroyTime = .5f;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            DestroyObject();
        }
    }

    private void DestroyObject()
    {
        Destroy(gameObject, destroyTime);
    }
}
