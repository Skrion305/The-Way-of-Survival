using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] GameObject door;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Door"))
        {
            door.transform.rotation = Quaternion.Euler(0f, -10.31f, 0f);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Door"))
        {
            door.transform.rotation = Quaternion.Euler(0f, 90f, 0f);
        }
    }
}
