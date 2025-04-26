using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class UI : MonoBehaviour
{
    public GameObject panel;
    public void InHand(SelectEnterEventArgs args)
    {
        panel.SetActive(true);
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
