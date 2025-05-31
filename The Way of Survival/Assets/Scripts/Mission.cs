using UnityEngine;
using TMPro;

public class Mission : MonoBehaviour
{
    [SerializeField] TMP_Text text;
    public int resources = 0;
    int res = 0;
    [SerializeField] GameObject wall;
    [SerializeField] GameObject panel;
    [SerializeField] Player player;
    void Start()
    {
        text.text = "Собрано ресурсов: " + resources.ToString() + "/3";
    }
    void Update()
    {
        if (resources == 3)
        {
            panel.SetActive(false);
            Destroy(wall);
            player.m = true;
        }
        else if (resources > res)
        {
            text.text = "Собрано ресурсов: " + resources.ToString() + "/3";
            res = resources;
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            text.text = "Собрано недостаточно ресурсов!";
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            text.text = "Собрано ресурсов: " + resources.ToString() + "/3";
        }
    }
}
