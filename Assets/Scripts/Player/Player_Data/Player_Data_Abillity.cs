using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class Player_Data_Ability : MonoBehaviour
{
    public UnityEvent[] attack;
    public UnityEvent[] spellCast, spellA, spellB, spellC;
    public UnityEvent[] damageAnswer;

    private Coroutine attackCoroutine;
    private Player_Data_Stats stats;

    private void Start()
    {
        stats = GetComponent<Player_Data_Stats>();
    }

    public void Action_attack(InputAction.CallbackContext context)
    {
        if (context.started && attackCoroutine == null)
        {
            // Start the attack coroutine when the button is first pressed
            attackCoroutine = StartCoroutine(RepeatAttack());
        }
        else if (context.canceled && attackCoroutine != null)
        {
            // Stop the attack coroutine when the button is released
            StopCoroutine(attackCoroutine);
            attackCoroutine = null;
        }
    }

    public void Action_SpellCast(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            for (int i = 0; i < spellCast.Length; i++)
            {
                spellCast[i].Invoke();
            }
        }
    }

    public void Action_SpellA(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            for (int i = 0; i < spellA.Length; i++)
            {
                spellA[i].Invoke();
            }
        }
    }

    public void Action_SpellB(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            for (int i = 0; i < spellB.Length; i++)
            {
                spellB[i].Invoke();
            }
        }
    }

    public void Action_SpellC(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            for (int i = 0; i < spellC.Length; i++)
            {
                spellC[i].Invoke();
            }
        }
    }

    private IEnumerator RepeatAttack()
    {
        while (true)
        {
            // Invoke all attack events
            for (int i = 0; i < attack.Length; i++)
            {
                attack[i].Invoke();
            }

            // Wait for the specified interval before the next attack
            yield return new WaitForSeconds(stats.currentStats.attSpeed);
        }
    }
}
