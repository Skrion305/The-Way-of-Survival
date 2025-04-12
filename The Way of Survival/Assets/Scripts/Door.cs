using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] GameObject door;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            door.transform.Rotate(0, -90, 0);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            door.transform.Rotate(0, 90, 0);
        }
    }
}
