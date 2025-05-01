using UnityEngine;

public class ChaseState : BaseState
{
    public override void EnterState(EnemyStateManager manager)
    {
        manager.SetSpeed(4);
    }
    public override void ExitState(EnemyStateManager manager)
    {

    }
    public override void UpdateState(EnemyStateManager manager)
    {
        if (manager.Distance() >= 25)
        {
            manager.SwitchState(manager.idle);
            return;
        }
    }
}
