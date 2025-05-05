using UnityEngine;
using TMPro;

public class Damagedetector : MonoBehaviour
{
    int health = 100;
    [SerializeField] TMP_Text text;
    [SerializeField] GameObject panel;
    public void ondamagedetected(int damage)
    {
        health -= damage;
        text.text = "Health: " + health.ToString();
        if (health <= 0)
        {
            panel.SetActive(true);
        }
    }
}
