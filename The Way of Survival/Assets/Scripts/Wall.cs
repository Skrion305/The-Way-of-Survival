using UnityEngine;

public class Wall : MonoBehaviour
{
    [SerializeField] GameObject panel;
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Wall"))
        {
            panel.SetActive(true);
        }
    }
}
