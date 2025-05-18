using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Weapon : MonoBehaviour
{
    [SerializeField] GameObject panel;
    [SerializeField] GameObject indic;
    bool ui = false;
    float timer;
    bool inHand = false;
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
        /*if (args.interactableObject.transform.CompareTag("Infected"))
        {

        }*/
        if ((!ui) && (args.interactableObject.transform.CompareTag("Weapon")))
        {
            panel.SetActive(true);
            ui = true;
            indic.SetActive(false);
            inHand = true;
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
