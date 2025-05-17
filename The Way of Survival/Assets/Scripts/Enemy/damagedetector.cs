using UnityEngine;
using TMPro;

public class Damagedetector : MonoBehaviour
{
    Player player;
    public void ondamagedetected(int damage)
    {
        player.health -= damage;
    }
}
