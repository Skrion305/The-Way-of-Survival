using UnityEngine;

public class SearchState : BaseState
{
    public override void EnterState(EnemyStateManager manager)
    {
        manager.SetSpeed(manager.searchSpeed);
        if (manager.point == 1)
        {
            manager.SetDestination(manager.point2);
            manager.point = 2;
        }
        else
        {
            manager.SetDestination(manager.point1);
            manager.point = 1;
        }
        manager.animator.SetBool("isagro", true);
        manager.animator.SetBool("isattack", false);
    }
    public override void UpdateState(EnemyStateManager manager)
    {
        if (manager.Distance(manager.player) < manager.chaseDistance)
        {
            manager.wait = 0f;
            manager.SwitchState(manager.chase);
            return;
        }
        if ((manager.point == 1) && (manager.Distance(manager.point1) < manager.searchDistance))
        {
            manager.SwitchState(manager.idle);
            return;
        }
        if ((manager.point == 2) && (manager.Distance(manager.point2) < manager.searchDistance))
        {
            manager.SwitchState(manager.idle);
            return;
        }
        if (manager.issdead == true)
        {
            manager.SwitchState(manager.dead);
            return;
        }
    }
}
