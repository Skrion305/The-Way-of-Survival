using UnityEngine;

public class ChaseState : BaseState
{
    public override void EnterState(EnemyStateManager manager)
    {
        manager.SetSpeed(manager.chaseSpeed);
    }
    public override void UpdateState(EnemyStateManager manager)
    {
        manager.SetDestination(manager.player);
        if (manager.Distance(manager.player) >= manager.chaseDistance)
        {
            manager.SwitchState(manager.idle);
            return;
        }
        if (manager.Distance(manager.player) < manager.attackDistance)
        {
            manager.SwitchState(manager.attack);
            return;
        }
    }
}
