using UnityEngine;

public class Damagedetector : MonoBehaviour
{
    public void ondamagedetected(int damage)
    {
        Debug.Log("игроку нанесли " + damage + " урона");
    }
}
