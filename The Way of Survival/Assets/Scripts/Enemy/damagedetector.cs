using UnityEngine;
using TMPro;

public class Damagedetector : MonoBehaviour
{
    int health = 100;
    [SerializeField] TMP_Text text;
    [SerializeField] GameObject losing;
    [SerializeField] GameObject indic;
    public void ondamagedetected(int damage)
    {
        health -= damage;
        text.text = "Health: " + health.ToString();
        if (health <= 0)
        {
            indic.SetActive(false);
            losing.SetActive(true);
        }
    }
}
