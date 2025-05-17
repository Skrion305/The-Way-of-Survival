using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Weapon : MonoBehaviour
{
    [SerializeField] GameObject panel;
    [SerializeField] GameObject indic;
    bool ui = false;
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
        }
    }
    public void NotInHand(SelectExitEventArgs args)
    {
        panel.SetActive(false);
        indic.SetActive(true);
    }
}
