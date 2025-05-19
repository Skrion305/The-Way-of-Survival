using UnityEngine;

public class Puddle : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Weapon"))
        {
            col.gameObject.tag = "Infected";
        }
    }
}
