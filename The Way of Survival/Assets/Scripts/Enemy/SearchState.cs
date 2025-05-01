using UnityEngine;

public class SearchState : BaseState
{
    public override void EnterState(EnemyStateManager manager)
    {
        manager.SetSpeed(manager.searchSpeed);
        manager.SetDestination(manager.point1);
    }
    public override void UpdateState(EnemyStateManager manager)
    {
        if (manager.Distance(manager.player) < manager.chaseDistance)
        {
            manager.wait = 0f;
            manager.SwitchState(manager.chase);
            return;
        }
        if (manager.Distance(manager.point1) == 0f)
        {
            if (manager.Waiting())
            {
                manager.wait = 0f;
                manager.SetDestination(manager.point2);
            }
        }
        if (manager.Distance(manager.point2) == 0f)
        {
            if (manager.Waiting())
            {
                manager.wait = 0f;
                manager.SetDestination(manager.point1);
            }
        }
    }
}
