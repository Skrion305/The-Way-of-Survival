using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class Shooting : MonoBehaviour
{
    public AudioClip fireclip;
    public AudioSource fire_source;
    public Transform raycastOrigin;
    public int range = 100;
    public int damage = 25;
    public ParticleSystem muzzleFlash;
    [SerializeField] Player player;

    public void Shoot()
    {
        if (player.patrons > 0)
        {
            muzzleFlash.Play();
            fire_source.Play();
            if (Physics.Raycast(raycastOrigin.position, raycastOrigin.forward, out RaycastHit hit, range))
            {
                HandleHit(hit);
            }
            player.patrons--;
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

