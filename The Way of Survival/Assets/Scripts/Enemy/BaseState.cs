using UnityEngine;

public abstract class BaseState
{
    public abstract void EnterState();
    public abstract void ExitState();
    public abstract void UpdateState();
}
