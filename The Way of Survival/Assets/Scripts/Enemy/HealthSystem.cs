using System.Threading;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    public int health = 100;
    public bool dead = false;
    [SerializeField] EnemyStateManager esm;
    [SerializeField] Player player;
    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0) {
            esm.issdead = true;
            player.kills++;
        }
    }
}