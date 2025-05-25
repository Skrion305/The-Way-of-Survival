using UnityEngine;

public class DeadState : BaseState
{
    public override void EnterState(EnemyStateManager manager)
    {
        manager.SetSpeed(0);
        manager.animator.SetBool("isdead", true);
        manager.animator.SetBool("isagro", false);
        manager.animator.SetBool("isattack", false);
    }
    public override void UpdateState(EnemyStateManager manager)
    {

    }
}
