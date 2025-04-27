using UnityEngine;
using TMPro;

public class Mission : MonoBehaviour
{
    [SerializeField] TMP_Text text;
    public int resources = 0;
    int res = 0;
    [SerializeField] GameObject wall;
    [SerializeField] GameObject panel;
    void Start()
    {
        text.text = "Собрано ресурсов: " + resources.ToString() + "/5";
    }
    void Update()
    {
        if (resources == 5)
        {
            panel.SetActive(false);
            Destroy(wall);
        }
        else if (resources > res)
        {
            text.text = "Собрано ресурсов: " + resources.ToString() + "/5";
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
            text.text = "Собрано ресурсов: " + resources.ToString() + "/5";
        }
    }
}
