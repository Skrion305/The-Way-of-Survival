using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public int health = 100;
    int h;
    [SerializeField] TMP_Text healthLevel;
    public int hunger = 100;
    int hr;
    [SerializeField] TMP_Text hungerLevel;
    public int food = 0;
    int f;
    [SerializeField] TMP_Text foodCount;
    public int med = 0;
    int mc;
    [SerializeField] TMP_Text medChests;
    public int patrons = 0;
    int p;
    [SerializeField] TMP_Text patronsCount;
    public int collec = 0;
    int c;
    [SerializeField] TMP_Text collection;
    [SerializeField] Mission mission;
    float timer;
    public bool m = false;
    [SerializeField] GameObject indic;
    [SerializeField] GameObject achieve;
    float achieveTimer = 0;
    bool achievement = false;
    public int kills = 0;
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
            if (health == 0)
            {
                GameData.losing = true;
                SceneManager.LoadScene("Menu");
            }
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
            if (patrons > 100)
            {
                patrons = 100;
            }
            p = patrons;
            patronsCount.text = p.ToString() + "/100";
        }
        if (collec != c)
        {
            c = collec;
            collection.text = c.ToString() + "/10";
            if ((collec == 10) && (!GameData.achieve1))
            {
                indic.SetActive(false);
                achieve.SetActive(true);
                achievement = true;
                GameData.achieve1 = true;
            }
        }
        if (achievement)
        {
            achieveTimer += Time.deltaTime;
            if (achieveTimer >= 5)
            {
                achieve.SetActive(false);
                indic.SetActive(true);
                achieveTimer = 0;
                achievement = false;
            }
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
        else if (m)
        {
            timer += Time.deltaTime;
            if (timer >= 2)
            {
                hunger--;
                timer = 0;
            }
        }
        if ((kills == 5) && (!GameData.achieve2))
        {
            indic.SetActive(false);
            achieve.SetActive(true);
            achievement = true;
            GameData.achieve2 = true;
        }
        if ((kills == 10) && (!GameData.achieve3))
        {
            indic.SetActive(false);
            achieve.SetActive(true);
            achievement = true;
            GameData.achieve3 = true;
        }
        if ((kills == 15) && (!GameData.achieve4))
        {
            indic.SetActive(false);
            achieve.SetActive(true);
            achievement = true;
            GameData.achieve4 = true;
        }
    }
}
