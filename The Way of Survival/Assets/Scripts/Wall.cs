using UnityEngine;

public class Wall : MonoBehaviour
{
    [SerializeField] GameObject panel;
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Wall"))
        {
            panel.SetActive(true); //Vector3(-0.902008057,0.977999926,6.24700928)
        }
    }
}
