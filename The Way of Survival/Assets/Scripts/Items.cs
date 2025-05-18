using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Items : MonoBehaviour
{
    [SerializeField] GameObject panel;
    [SerializeField] GameObject indic;
    bool ui = false;
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
                panel.SetActive(false);
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
        if ((!ui) && (args.interactableObject.transform.CompareTag("Weapon")))
        {
            panel.SetActive(true);
            ui = true;
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
                player.patrons += 25;
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
        panel.SetActive(false);
        indic.SetActive(true);
        inHand = false;
        timer = 0;
    }
}
