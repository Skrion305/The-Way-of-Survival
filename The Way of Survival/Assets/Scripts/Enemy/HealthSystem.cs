using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    public int health = 100;
    public bool dead = false;

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0) dead = true ;
    }
}