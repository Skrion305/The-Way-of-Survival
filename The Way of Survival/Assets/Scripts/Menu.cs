using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Menu : MonoBehaviour
{
    [SerializeField] GameObject panel1;
    [SerializeField] GameObject panel2;
    [SerializeField] Slider slider;
    [SerializeField] TMP_Text text;
    [SerializeField] AudioSource audioSource;
    void Start()
    {
        AudioListener.volume = Settings.volumeLevel;
        slider.value = Settings.volumeLevel;
        if (Settings.music)
        {
            audioSource.volume = 1f;
            text.text = "Выключить";
        }
        else
        {
            audioSource.volume = 0f;
            text.text = "Включить";
        }
    }
    public void StartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void GameSettings()
    {
        panel1.SetActive(false);
        panel2.SetActive(true);
    }
    public void Volume(float value)
    {
        Settings.volumeLevel = value;
        AudioListener.volume = value;
    }
    public void Music()
    {
        if (Settings.music)
        {
            audioSource.volume = 0f;
            text.text = "Включить";
            Settings.music = false;
        }
        else
        {
            audioSource.volume = 1f;
            text.text = "Выключить";
            Settings.music = true;
        }
    }
    public void Back()
    {
        panel2.SetActive(false);
        panel1.SetActive(true);
    }
    public void ExitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }
}
