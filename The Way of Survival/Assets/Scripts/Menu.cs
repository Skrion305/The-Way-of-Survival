using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField] GameObject panel1;
    [SerializeField] GameObject panel2;
    void Update()
    {
        AudioListener.volume = Settings.volumeLevel;
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
