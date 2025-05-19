using UnityEngine;

public class AttackState : BaseState
{
    public override void EnterState(EnemyStateManager manager)
    {
        manager.SetSpeed(manager.attackSpeed);
        manager.animator.SetBool("isattack", true);
        manager.animator.SetBool("isagro", false);
    }
    public override void UpdateState(EnemyStateManager manager)
    {
        manager.sound_attack1.Play();
        manager.transform.LookAt(manager.player);
        if (manager.issdead == true)
        {
            manager.SwitchState(manager.dead);
            return;
        }
    }
    /*    if (manager.Distance(manager.player) >= manager.attackDistance)
    //    {
    //        manager.SwitchState(manager.chase);
    //        return;
    //    }
    }*/
}
