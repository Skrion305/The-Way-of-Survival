using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    public int health = 100;
    int h;
    [SerializeField] TMP_Text text;
    void Start()
    {
        h = health;
        text.text = "Health: " + h.ToString();
    }
    private void Update()
    {
        if (health != h)
        {
            h = health;
            text.text = "Health: " + h.ToString();
        }
    }
}
