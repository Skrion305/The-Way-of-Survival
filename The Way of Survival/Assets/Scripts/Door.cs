using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] GameObject door;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Da");
            door.transform.rotation = Quaternion.Lerp(door.transform.rotation, Quaternion.Euler(0, -90f, 0), 2 * Time.deltaTime);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Net");
            door.transform.rotation = Quaternion.Lerp(door.transform.rotation, Quaternion.Euler(0, 90f, 0), 2 * Time.deltaTime);
        }
    }
}
