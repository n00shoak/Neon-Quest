using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;


public class Player_Data_Abillity : MonoBehaviour
{
    public UnityEvent[] attack;
    public UnityEvent[] spellCast,spellA, spellB, spellC;
    public UnityEvent[] damageAwnser;


    public void Action_attack(InputAction.CallbackContext context)
    {
        for (int i = 0; i < attack.Length; i++)
        {
            attack[i].Invoke();
        } 
    }

    public void Action_SpellCast(InputAction.CallbackContext context)
    {
        
        for(int i = 0;i < spellCast.Length; i++)
        {
            spellCast[i].Invoke();
        }
    }

    public void Action_SpellA(InputAction.CallbackContext context)
    {
        for (int i = 0; i < attack.Length; i++)
        {
            spellA[i].Invoke();
        }
    }

    public void Action_SpellB(InputAction.CallbackContext context)
    {
        for (int i = 0; i < attack.Length; i++)
        {
            spellB[i].Invoke();
        }
    }

    public void Action_SpellC(InputAction.CallbackContext context)
    {
        for (int i = 0; i < attack.Length; i++)
        {
            spellC[i].Invoke();
        }
    }
}