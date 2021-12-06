using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private Timer timer;
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        timer.gameObject.SetActive(true);
        timer.ResetTimer();
        PlayerPrefs.SetInt("deaths", 0);
        DontDestroyOnLoad(timer);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
