using Unity.VisualScripting;
using UnityEngine;

public class Damage : MonoBehaviour
{
    [SerializeField] int damage;
    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent<Damagedetector>(out Damagedetector damagedetector))
        {
            damagedetector.ondamagedetected(damage);
            GetComponent<Collider>().enabled = false;
        }
    }
}
