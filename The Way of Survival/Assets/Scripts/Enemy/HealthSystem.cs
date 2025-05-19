using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    public int health = 100;
    public bool dead = false;
    [SerializeField] EnemyStateManager esm;

    public void TakeDamage(int damage)
    {
        health -= damage;Debug.Log("òûù");
        if (health <= 0) {
            esm.issdead = true;
            
        } ;
    }
}