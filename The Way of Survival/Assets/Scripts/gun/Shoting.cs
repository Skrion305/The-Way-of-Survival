using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class Shoting : MonoBehaviour
{
    public AudioClip fireclip;
    public AudioSource fire_source;
    public Transform raycastOrigin;
    public int range = 100;
    public int damage = 25;


    public void Shoot()
    {
        fire_source.Play();
    }
}
