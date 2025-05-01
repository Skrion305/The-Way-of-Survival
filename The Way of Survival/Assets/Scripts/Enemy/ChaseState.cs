using UnityEngine;

public class ChaseState : BaseState
{
    public override void EnterState(EnemyStateManager manager)
    {
        manager.SetSpeed(manager.chaseSpeed);
        manager.SetDestination(manager.player);
    }
    public override void UpdateState(EnemyStateManager manager)
    {
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
