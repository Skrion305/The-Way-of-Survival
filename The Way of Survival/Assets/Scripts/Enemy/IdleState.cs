using UnityEngine;

public class IdleState : BaseState
{
    public override void EnterState(EnemyStateManager manager)
    {
        manager.SetSpeed(manager.idleSpeed);
        manager.animator.SetBool("isagro",false);
        manager.animator.SetBool("isattack",false);
    }
    public override void UpdateState(EnemyStateManager manager)
    {
        if (manager.Waiting())
        {
            manager.wait = 0f;
            manager.SwitchState(manager.search);
            return;
        }
        if (manager.Distance(manager.player) < manager.chaseDistance)
        {
            manager.wait = 0f;
            manager.SwitchState(manager.chase);
            return;
        }
    }
}
