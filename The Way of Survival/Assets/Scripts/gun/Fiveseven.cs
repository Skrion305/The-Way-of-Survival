using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

[RequireComponent(typeof(XRGrabInteractable))]
public class VRGunRaycast : MonoBehaviour
{
    [Header("Gun Settings")]
    public Transform raycastOrigin;
    public int range = 100;
    public int damage = 25;
    public float fireRate = 0.2f;
    public int maxAmmo = 12;
    public float reloadTime = 2f;
    public LayerMask hitLayers;

    [Header("Effects")]
    public ParticleSystem muzzleFlash;
    public AudioClip shootSound;
    public AudioClip reloadSound;
    public GameObject hitEffectPrefab;

    private AudioSource audioSource;
    private XRGrabInteractable grabInteractable;
    private float lastFireTime;
    private int currentAmmo;
    private bool isReloading = false;

    private void Awake()
    {
        grabInteractable = GetComponent<XRGrabInteractable>();
        audioSource = GetComponent<AudioSource>();
        currentAmmo = maxAmmo;
    }

    private void OnEnable()
    {
        grabInteractable.activated.AddListener(TriggerPulled);
    }

    private void OnDisable()
    {
        grabInteractable.activated.RemoveListener(TriggerPulled);
    }

    private void TriggerPulled(ActivateEventArgs arg)
    {
        if (CanShoot())
        {
            Shoot();
        }
        else if (!isReloading && currentAmmo <= 0)
        {
            StartCoroutine(Reload());
        }
    }

    private bool CanShoot()
    {
        return !isReloading &&
               currentAmmo > 0 &&
               Time.time > lastFireTime + fireRate;
    }

    private void Shoot()
    {
        lastFireTime = Time.time;
        currentAmmo--;

        // Ёффекты выстрела
        if (muzzleFlash != null) muzzleFlash.Play();
        if (shootSound != null) audioSource.PlayOneShot(shootSound);


        
        if (Physics.Raycast(raycastOrigin.position, raycastOrigin.forward, out RaycastHit hit, range, hitLayers))
        {
            
            HandleHit(hit);

            
            if (hitEffectPrefab != null)
            {
                Instantiate(hitEffectPrefab, hit.point, Quaternion.LookRotation(hit.normal));
            }
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

    private System.Collections.IEnumerator Reload()
    {
        isReloading = true;
        if (reloadSound != null) audioSource.PlayOneShot(reloadSound);

        yield return new WaitForSeconds(reloadTime);

        currentAmmo = maxAmmo;
        isReloading = false;
    }

    
    public string GetAmmoInfo()
    {
        return $"{currentAmmo}/{maxAmmo}";
    }
}