using UnityEngine;

/// <summary>
/// Player moving State 
/// only move and do basic attack
/// </summary>
public class Player_StateMachine_StateA : Player_StateMachine_AbstractState
{
    public override void EnterState(Player_StateMachine_Context _context)
    {
        // set State Stats

    }

    public override void UpdateState(Player_StateMachine_Context _context)
    {
        // move
        // shoot
    }

    public override void EndState(Player_StateMachine_Context _context)
    {
    }
}
