using UnityEngine;
using static UnityEngine.Rendering.GPUSort;

public class Puddle : MonoBehaviour
{
    bool weapon = false;
    void OnTriggerEnter(Collider col)
    {
        weapon = (col.CompareTag("Gun")) || (col.CompareTag("Axe")) || (col.CompareTag("Knife"));
        if (weapon)
        {
            col.gameObject.tag = "Infected";
        }
    }
}
