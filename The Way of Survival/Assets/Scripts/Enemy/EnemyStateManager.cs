using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Rendering;

public class EnemyStateManager : MonoBehaviour
{
    [SerializeField] NavMeshAgent nma;
    [SerializeField] Collider damageCollider;
    public Animator animator;
    public Transform player;
    public Transform point1;
    public Transform point2;
    public float idleSpeed;
    public float searchSpeed;
    public float searchDistance;
    public int point;
    public float wait;
    public float chaseDistance;
    public float chaseSpeed;
    public float attackDistance;
    public float attackSpeed;
    BaseState state;
    public IdleState idle = new IdleState();
    public DeadState dead = new DeadState();
    public SearchState search = new SearchState();
    public ChaseState chase = new ChaseState();
    public AttackState attack = new AttackState();
    public bool issdead;
    [SerializeField] public AudioSource sound_attack1, sound_chase1;
    void Start()
    {
        SwitchState(idle);
    }
    void Update()
    {
        state.UpdateState(this);
    }
    public void SwitchState(BaseState newState)
    {
        state = newState;
        state.EnterState(this);
    }
    public void SetSpeed(float newSpeed)
    {
        nma.speed = newSpeed;
    }
    public void SetDestination(Transform newDestination)
    {
        nma.destination = newDestination.position;
    }
    public float Distance(Transform target)
    {
        return (transform.position - target.position).magnitude;
    }
    public bool Waiting()
    {
        wait += Time.deltaTime;
        if (wait >= 5f)
        {
            return true;
        }
        return false;
    }
    void CheckConditions()
    {
        if (state == attack)
        {
            if (Distance(player) >= attackDistance)
            {
                SwitchState(chase);
                return;
            }
        }
    }
    void OnofDamager(int isoff)
    {
        if(isoff == 0)
        {
            damageCollider.enabled = false;
        }
        else
        {
            damageCollider.enabled = true;
        }
    }
}
