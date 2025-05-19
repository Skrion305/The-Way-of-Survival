using UnityEngine;
using UnityEngine.SceneManagement;

public class Victory : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameData.victory = true;
            SceneManager.LoadScene("Menu");
        }
    }
}
