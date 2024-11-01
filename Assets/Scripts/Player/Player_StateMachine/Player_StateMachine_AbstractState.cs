using UnityEngine;

public abstract class Player_StateMachine_AbstractState 
{
    public abstract void EnterState(Player_StateMachine_Context context);

    public abstract void UpdateState(Player_StateMachine_Context context);

    public abstract void EndState(Player_StateMachine_Context context);

}
