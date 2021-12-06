using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    private string WhatsLoaded = "";
    [SerializeField] private GameObject pauseMenuUI;
    [SerializeField] private GameObject optionsMenuUI;

    [SerializeField] private Slider SFXSlider;
    [SerializeField] private Slider musicSlider;
    public AudioMixer audioMixer;
    private float musicVol;
    [SerializeField] private float SFXVol;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                if (WhatsLoaded == "PauseMenu")
                {
                    Resume();
                }
                else if (WhatsLoaded == "OptionsMenu")
                {
                    BackFromOptions();
                }
            } else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        WhatsLoaded = "PauseMenu";
    }

    public void LoadOptions()
    {
        pauseMenuUI.SetActive(false);
        optionsMenuUI.SetActive(true);
        WhatsLoaded = "OptionsMenu";
    }

    public void BackFromOptions()
    {
        optionsMenuUI.SetActive(false);
        pauseMenuUI.SetActive(true);
        WhatsLoaded = "PauseMenu";
    }

    public void LoadMenu()
    {
        Resume();
        SceneManager.LoadScene("Start Screen");
    }

}
