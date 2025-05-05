using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class UI : MonoBehaviour
{
    [SerializeField] GameObject panel;
    [SerializeField] GameObject losing;
    [SerializeField] GameObject mission;
    public void InHand(SelectEnterEventArgs args)
    {
        if (args.interactableObject.transform.CompareTag("Infected"))
        {
            losing.SetActive(true);
        }
        else if (args.interactableObject.transform.CompareTag("Weapon"))
        {
            panel.SetActive(true);
            mission.SetActive(false);
        }
    }
    public void NotInHand(SelectExitEventArgs args)
    {
        panel.SetActive(false);
        mission.SetActive(true);
    }
    public void Close()
    {
        panel.SetActive(false);
        mission.SetActive(true);
    }
}
