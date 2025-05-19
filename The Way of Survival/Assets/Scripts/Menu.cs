using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Menu : MonoBehaviour
{
    [SerializeField] GameObject mainMenu;
    [SerializeField] GameObject settings;
    [SerializeField] Slider slider;
    [SerializeField] TMP_Text text;
    [SerializeField] AudioSource audioSource;
    [SerializeField] GameObject achievements;
    [SerializeField] TMP_Text achievement1;
    [SerializeField] TMP_Text achievement2;
    [SerializeField] TMP_Text achievement3;
    [SerializeField] TMP_Text achievement4;
    [SerializeField] GameObject victory;
    [SerializeField] GameObject losing;
    void Start()
    {
        AudioListener.volume = GameData.volumeLevel;
        slider.value = GameData.volumeLevel;
        if (GameData.music)
        {
            audioSource.volume = 1f;
            text.text = "Выключить";
        }
        else
        {
            audioSource.volume = 0f;
            text.text = "Включить";
        }
        if (GameData.achieve1)
        {
            achievement1.color = new Color(1f, 1f, 0f, 1f);
        }
        if (GameData.achieve2)
        {
            achievement2.color = new Color(1f, 1f, 0f, 1f);
        }
        if (GameData.achieve3)
        {
            achievement3.color = new Color(1f, 1f, 0f, 1f);
        }
        if (GameData.achieve4)
        {
            achievement4.color = new Color(1f, 1f, 0f, 1f);
        }
        if (GameData.victory)
        {
            mainMenu.SetActive(false);
            victory.SetActive(true);
            GameData.victory = false;
        }
        if (GameData.losing)
        {
            mainMenu.SetActive(false);
            losing.SetActive(true);
            GameData.losing = false;
        }
    }
    public void StartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void GameSettings()
    {
        mainMenu.SetActive(false);
        settings.SetActive(true);
    }
    public void Volume(float value)
    {
        GameData.volumeLevel = value;
        AudioListener.volume = value;
    }
    public void Music()
    {
        if (GameData.music)
        {
            audioSource.volume = 0f;
            text.text = "Включить";
            GameData.music = false;
        }
        else
        {
            audioSource.volume = 1f;
            text.text = "Выключить";
            GameData.music = true;
        }
    }
    public void Back()
    {
        settings.SetActive(false);
        achievements.SetActive(false);
        victory.SetActive(false);
        losing.SetActive(false);
        mainMenu.SetActive(true);
    }
    public void ExitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }
    public void Achievements()
    {
        mainMenu.SetActive(false);
        victory.SetActive(false);
        losing.SetActive(false);
        achievements.SetActive(true);
    }
}
