using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class UI : MonoBehaviour
{
    [SerializeField] GameObject panel;
    [SerializeField] GameObject losing;
    [SerializeField] GameObject m;
    [SerializeField] GameObject indic;
    bool ui = false;
    bool lose = false;
    public Mission mission;
    public void InHand(SelectEnterEventArgs args)
    {
        if (args.interactableObject.transform.CompareTag("Infected"))
        {
            losing.SetActive(true);
            indic.SetActive(false);
            lose = true;
        }
        else if ((!ui) && (args.interactableObject.transform.CompareTag("Weapon")))
        {
            panel.SetActive(true);
            ui = true;
            m.SetActive(false);
            indic.SetActive(false);
        }
    }
    public void NotInHand(SelectExitEventArgs args)
    {
        Close();
    }
    public void Close()
    {
        panel.SetActive(false);
        if (mission.resources < 5)
        {
            m.SetActive(true);
        }
        else if (!lose)
        {
            indic.SetActive(true);
        }
    }
}
