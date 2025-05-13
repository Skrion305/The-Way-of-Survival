using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

public class LeftRight : XRGrabInteractable
{
    [SerializeField] Transform left;
    [SerializeField] Transform right;
    protected override void OnSelectEntering(SelectEnterEventArgs args)
    {
        if (args.interactorObject.transform.CompareTag("Left"))
        {
            attachTransform = left;
        }
        else
        {
            attachTransform = right;
        }
        base.OnSelectEntering(args);
    }
}
