using UnityEngine;
using static UnityEngine.Rendering.GPUSort;

public class Puddle : MonoBehaviour
{
    bool weapon = false;
    [SerializeField] Player player;
    void OnTriggerEnter(Collider col)
    {
        weapon = (col.CompareTag("Gun")) || (col.CompareTag("Axe")) || (col.CompareTag("Knife")) || (col.CompareTag("Revolver"));
        if (weapon)
        {
            col.gameObject.tag = "Infected";
        }
        if (col.CompareTag("Player"))
        {
            player.health = 0;
        }
    }
}
