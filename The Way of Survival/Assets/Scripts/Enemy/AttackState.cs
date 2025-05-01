using UnityEngine;

public class AttackState : BaseState
{
    public override void EnterState(EnemyStateManager manager)
    {
        manager.SetSpeed(manager.attackSpeed);
        Debug.Log("Враг атакует");
    }
    public override void UpdateState(EnemyStateManager manager)
    {
        if (manager.Distance(manager.player) >= manager.attackDistance)
        {
            manager.SwitchState(manager.chase);
            return;
        }
    }
}
