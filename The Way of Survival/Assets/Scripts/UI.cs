using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class UI : MonoBehaviour
{
    [SerializeField] GameObject panel;
    [SerializeField] GameObject losing;
    bool ui = false;
    public void InHand(SelectEnterEventArgs args)
    {
        if (args.interactableObject.transform.CompareTag("Infected"))
        {
            losing.SetActive(true);
        }
        else if ((!ui) && (args.interactableObject.transform.CompareTag("Weapon")))
        {
            panel.SetActive(true);
            ui = true;
        }
    }
    public void NotInHand(SelectExitEventArgs args)
    {
        panel.SetActive(false);
    }
    public void Close()
    {
        panel.SetActive(false);
    }
}
