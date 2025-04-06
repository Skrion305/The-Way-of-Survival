using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class UI : MonoBehaviour
{
    public GameObject canvas;
    public void InHand(SelectEnterEventArgs args)
    {
        canvas.SetActive(true);
    }
    public void NotInHand(SelectExitEventArgs args)
    {
        canvas.SetActive(false);
    }
    public void Close()
    {
        canvas.SetActive(false);
    }
}
