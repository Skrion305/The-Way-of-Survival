using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    public int health = 100;
    int h;
    [SerializeField] TMP_Text healthLevel;
    int hunger = 100;
    int hr;
    [SerializeField] TMP_Text hungerLevel;
    int food = 0;
    int f;
    [SerializeField] TMP_Text foodCount;
    int med = 0;
    int mc;
    [SerializeField] TMP_Text medChests;
    int patrons = 0;
    int p;
    [SerializeField] TMP_Text patronsCount;
    int collec = 0;
    int c;
    [SerializeField] TMP_Text collection;
    [SerializeField] Mission mission;
    float timer;
    void Start()
    {
        h = health;
        healthLevel.text = h.ToString();
        hr = hunger;
        hungerLevel.text = hr.ToString();
        f = food;
        foodCount.text = f.ToString() + "/10";
        mc = med;
        medChests.text = mc.ToString() + "/3";
        p = patrons;
        patronsCount.text = p.ToString() + "/50";
        c = collec;
        collection.text = c.ToString() + "/10";
    }
    void Update()
    {
        if (health != h)
        {
            if (health < 0)
            {
                health = 0;
            }
            if (health > 100)
            {
                health = 100;
            }
            h = health;
            healthLevel.text = h.ToString();
        }
        if (hunger != hr)
        {
            if (hunger < 0)
            {
                hunger = 0;
            }
            if (hunger > 100)
            {
                hunger = 100;
            }
            hr = hunger;
            hungerLevel.text = hr.ToString();
        }
        if (food != f)
        {
            f = food;
            foodCount.text = f.ToString() + "/10";
        }
        if (med != mc)
        {
            mc = med;
            medChests.text = mc.ToString() + "/3";
        }
        if (patrons != p)
        {
            p = patrons;
            patronsCount.text = p.ToString() + "/50";
        }
        if (collec != c)
        {
            c = collec;
            collection.text = c.ToString() + "/10";
        }
        if (hunger == 0)
        {
            timer += Time.deltaTime;
            if (timer >= 5)
            {
                health--;
                timer = 0;
            }
        }
        else if (mission.resources >= 5)
        {
            timer += Time.deltaTime;
            if (timer >= 2)
            {
                hunger--;
                timer = 0;
            }
        }
    }
}
