using UnityEngine;

public class Wall : MonoBehaviour
{
    [SerializeField] GameObject panel;
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            Debug.Log("Da");
            panel.SetActive(true);
        }
    }
    private void OnCollisionExit(Collision col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            Debug.Log("Net");
            panel.SetActive(false);
        }
    }
}
