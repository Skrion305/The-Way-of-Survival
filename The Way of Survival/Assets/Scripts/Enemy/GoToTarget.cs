using UnityEngine;

public class GoToTarget : MonoBehaviour
{
    [SerializeField] UnityEngine.AI.NavMeshAgent nma;
    [SerializeField] Transform player;
    void Update()
    {
        nma.destination = player.position;
    }
}
