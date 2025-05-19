using UnityEngine;

public class DeadState : BaseState
{
    public override void EnterState(EnemyStateManager manager)
    {
        manager.SetSpeed(manager.chaseSpeed);
        manager.animator.SetBool("isdead", true);
    }
    public override void UpdateState(EnemyStateManager manager)
    {
        if (manager.issdead == true) 
        {
            manager.SwitchState(manager.dead);
            return;
        }
        
    }
}
