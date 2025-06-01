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
    [SerializeField] AudioSource victoryMusic;
    [SerializeField] AudioSource losingMusic;
    void Start()
    {
        AudioListener.volume = GameData.volumeLevel;
        slider.value = GameData.volumeLevel;
        if (GameData.music)
        {
            audioSource.volume = 1f;
            victoryMusic.volume = 1f;
            losingMusic.volume = 1f;
            text.text = "Выключить";
        }
        else
        {
            audioSource.volume = 0f;
            victoryMusic.volume = 0f;
            losingMusic.volume = 0f;
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
            if (GameData.music)
            {
                PlayVictoryMusic();
            }
            GameData.victory = false;
        }
        if (GameData.losing)
        {
            mainMenu.SetActive(false);
            losing.SetActive(true);
            if (GameData.music)
            {
                PlayLosingMusic();
            }
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
        Application.Quit();
    }
    public void Achievements()
    {
        mainMenu.SetActive(false);
        victory.SetActive(false);
        losing.SetActive(false);
        achievements.SetActive(true);
    }
    void PlayBackgroundMusic()
    {
        victoryMusic.Stop();
        losingMusic.Stop();
        audioSource.Play();
    }
    void PlayVictoryMusic()
    {
        audioSource.Stop();
        victoryMusic.Play();
        Invoke(nameof(PlayBackgroundMusic), victoryMusic.clip.length);
    }
    void PlayLosingMusic()
    {
        audioSource.Stop();
        losingMusic.Play();
        Invoke(nameof(PlayBackgroundMusic), losingMusic.clip.length);
    }
}
