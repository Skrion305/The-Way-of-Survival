using UnityEngine;

public class Sound : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;
    void Start()
    {
        AudioListener.volume = GameData.volumeLevel;
        if (GameData.music)
        {
            audioSource.volume = 1f;
        }
        else
        {
            audioSource.volume = 0f;
        }
    }
}
