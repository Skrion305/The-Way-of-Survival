using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class Shoting : MonoBehaviour
{
    public AudioClip fireclip;
    public AudioSource fire_source;
    public Transform raycastOrigin;
    public int range = 100;
    public int damage = 25;
    public ParticleSystem muzzleFlash;


    public void Shoot()
    {
        muzzleFlash.Play();
        fire_source.Play();
        if (Physics.Raycast(raycastOrigin.position, raycastOrigin.forward, out RaycastHit hit, range))
        {

            HandleHit(hit);


        }

    }

    private void HandleHit(RaycastHit hit)
    {
        // нанесение урона
        HealthSystem health = hit.collider.GetComponent<HealthSystem>();
        if (health != null)
        {
            health.TakeDamage(damage);
        }
    }
}

