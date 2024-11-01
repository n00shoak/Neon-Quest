using UnityEngine;

public class Player_StateMachine_Context : MonoBehaviour
{
    private Player_StateMachine_AbstractState currentState;

    public Player_StateMachine_StateA defaultState; 
    public Player_StateMachine_StateB idleState;
    //casting
    //stuned

    private void Start()
    {
        currentState = defaultState;
    }

    private void Update()
    {
        currentState.UpdateState(this);
    }

    public void SwitchState(Player_StateMachine_AbstractState _newState)
    {
        currentState.EndState(this);
        currentState = _newState;
    }
}
