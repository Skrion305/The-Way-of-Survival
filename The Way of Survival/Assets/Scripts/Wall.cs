using UnityEngine;

public class Wall : MonoBehaviour
{
    public GameObject panel;
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Wall"))
        {
            panel.SetActive(true);
        }
    }
}
