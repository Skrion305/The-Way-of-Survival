using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

[RequireComponent(typeof(LeftRight))]
public class VRKnife : MonoBehaviour
{
    [Header("Damage Settings")]
    public int damage = 25;
    public float attackCooldown = 0.5f;
    public float stabDistance = 0.3f;

    [Header("Effects")]
    public AudioClip stabSound;
    public ParticleSystem bloodEffect;

    private LeftRight grabInteractable;
    private AudioSource audioSource;
    private float lastAttackTime;
    private Vector3 previousPosition;

    private void Awake()
    {
        grabInteractable = GetComponent<LeftRight>();
        audioSource = GetComponent<AudioSource>();
        previousPosition = transform.position;
    }

    private void Update()
    {
        // Определяем скорость движения ножа
        float movementSpeed = (transform.position - previousPosition).magnitude / Time.deltaTime;
        previousPosition = transform.position;

        // Автоатака при быстром движении
        if (grabInteractable.isSelected && movementSpeed > 2f && Time.time > lastAttackTime + attackCooldown)
        {
            TryStab();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (grabInteractable.isSelected && Time.time > lastAttackTime + attackCooldown)
        {
            TryStab(other);
        }
    }

    private void TryStab(Collider other = null)
    {
        lastAttackTime = Time.time;

        // Визуальные и звуковые эффекты
        if (stabSound) audioSource.PlayOneShot(stabSound);

        // Если есть конкретный коллайдер - проверяем его
        if (other != null)
        {
            ApplyDamage(other.gameObject);
            return;
        }

        // Raycast для автоатаки
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, stabDistance))
        {
            ApplyDamage(hit.collider.gameObject);
        }
    }

    private void ApplyDamage(GameObject target)
    {
        // Наносим урон
        HealthSystem health = target.GetComponent<HealthSystem>();
        if (health != null)
        {
            health.TakeDamage(damage);

            // Эффект крови
            if (bloodEffect)
            {
                Instantiate(bloodEffect, target.transform.position, Quaternion.identity);
            }
        }
    }
}