using UnityEngine;
using UnityEngine.AI;

public class EnemyStateManager : MonoBehaviour
{
    [SerializeField] NavMeshAgent nma;
    [SerializeField] Transform player;
    Transform target;
    BaseState state;
    public IdleState idle = new IdleState();
    public SearchState search = new SearchState();
    public ChaseState chase = new ChaseState();
    public AttackState attack = new AttackState();
    public void SwitchState(BaseState newState)
    {
        if (state != null)
        {
            state.ExitState(this);
        }
        state = newState;
        state.EnterState(this);
    }
    void Start()
    {
        SwitchState(idle);
    }
    void Update()
    {
        SetDestination(player);
        nma.destination = target.position;
        state.UpdateState(this);
    }
    public void SetSpeed(float newSpeed)
    {
        nma.speed = newSpeed;
    }
    public void SetDestination(Transform newDestination)
    {
        target = newDestination;
    }
    public float Distance()
    {
        return (transform.position - target.position).magnitude;
    }
}
