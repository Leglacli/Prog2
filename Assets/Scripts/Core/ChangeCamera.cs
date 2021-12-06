using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCamera : MonoBehaviour
{
    [SerializeField] private Camera camera;
    [SerializeField] private float ortoSizeEnter;
    [SerializeField] private float ortoSizeExit;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            camera.orthographicSize = ortoSizeEnter;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            camera.orthographicSize = ortoSizeExit;
        }
    }
}
