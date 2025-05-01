using UnityEngine;
using UnityEngine.AI;

public class GoToTarget : MonoBehaviour
{
    [SerializeField] NavMeshAgent nma;
    [SerializeField] Transform player;
    void Update()
    {
        nma.destination = player.position;
    }
}
