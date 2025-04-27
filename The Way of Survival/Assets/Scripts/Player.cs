using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    public int health = 100;
    public int hunger = 100;
    public int food = 0;
    public int medChests = 0;
    public int ammun = 0;
    public int collec = 0;
    public int reqResources = 0;
    //[SerializeField] TMP_Text healthLevel;
    //[SerializeField] TMP_Text hungerLevel;
    [SerializeField] TMP_Text countRes;
    void Start()
    {
        //healthLevel.text = health.ToString();
        //hungerLevel.text = hunger.ToString();
        countRes.text = reqResources.ToString() + "/5";
    }
    void Update()
    {
        
    }
}
