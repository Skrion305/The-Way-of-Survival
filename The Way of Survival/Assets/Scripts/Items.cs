using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Items : MonoBehaviour
{
    [SerializeField] GameObject panel1;
    [SerializeField] GameObject panel2;
    [SerializeField] GameObject panel3;
    [SerializeField] GameObject indic;
    bool ui1 = false;
    bool ui2 = false;
    bool ui3 = false;
    float timer;
    bool inHand = false;
    [SerializeField] Player player;
    [SerializeField] Mission mission;
    void Update()
    {
        if (inHand)
        {
            timer += Time.deltaTime;
            if (timer >= 5)
            {
                panel1.SetActive(false);
                panel2.SetActive(false);
                panel3.SetActive(false);
                indic.SetActive(true);
                inHand = false;
                timer = 0;
            }
        }
    }
    public void InHand(SelectEnterEventArgs args)
    {
        if (args.interactableObject.transform.CompareTag("Infected"))
        {
            player.health = 0;
        }
        if ((!ui1) && (args.interactableObject.transform.CompareTag("Gun")))
        {
            panel1.SetActive(true);
            ui1 = true;
            indic.SetActive(false);
            inHand = true;
        }
        if ((!ui2) && (args.interactableObject.transform.CompareTag("Axe")))
        {
            panel2.SetActive(true);
            ui2 = true;
            indic.SetActive(false);
            inHand = true;
        }
        if ((!ui3) && (args.interactableObject.transform.CompareTag("Knife")))
        {
            panel3.SetActive(true);
            ui3 = true;
            indic.SetActive(false);
            inHand = true;
        }
        if (args.interactableObject.transform.CompareTag("Food"))
        {
            if (!player.m)
            {
                Destroy(gameObject);
                mission.resources++;
            }
            else if (player.food < 10)
            {
                Destroy(gameObject);
                player.food++;
            }
            else
            {
                args.manager.CancelInteractableSelection(args.interactableObject);
            }
        }
        if (args.interactableObject.transform.CompareTag("Medical chest"))
        {
            if (!player.m)
            {
                Destroy(gameObject);
                mission.resources++;
            }
            else if (player.med < 3)
            {
                Destroy(gameObject);
                player.med++;
            }
            else
            {
                args.manager.CancelInteractableSelection(args.interactableObject);
            }
        }
        if (args.interactableObject.transform.CompareTag("Patrons"))
        {
            if (player.patrons < 50)
            {
                Destroy(gameObject);
                player.patrons += 50;
            }
            else
            {
                args.manager.CancelInteractableSelection(args.interactableObject);
            }
        }
        if (args.interactableObject.transform.CompareTag("Collection"))
        {
            Destroy(gameObject);
            player.collec++;
        }
    }
    public void NotInHand(SelectExitEventArgs args)
    {
        panel1.SetActive(false);
        panel2.SetActive(false);
        panel3.SetActive(false);
        indic.SetActive(true);
        inHand = false;
        timer = 0;
    }
}
