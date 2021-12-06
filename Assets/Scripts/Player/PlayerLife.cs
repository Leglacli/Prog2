using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerLife : MonoBehaviour
{
    private Animator anim;
    private Rigidbody2D rb;
    private CameraController camera;

    [SerializeField] private AudioSource deathSoundEffect;
    [SerializeField] private Text deathsText;

    private void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        deathsText.text = "Deaths: " + PlayerPrefs.GetInt("deaths");
        //DontDestroyOnLoad(deathsText.gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Trap"))
        {
            KillPlayer();
        }
    }

    public void KillPlayer()
    {
        deathSoundEffect.Play();
        rb.bodyType = RigidbodyType2D.Static;
        anim.SetTrigger("death");
        IncreaseDeaths();
    }

    private void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void IncreaseDeaths()
    {
        PlayerPrefs.SetInt("deaths", PlayerPrefs.GetInt("deaths") + 1);
        deathsText.text = "Deaths: " + PlayerPrefs.GetInt("deaths");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Barrier"))
        {
            KillPlayer();
        }
    }
}
