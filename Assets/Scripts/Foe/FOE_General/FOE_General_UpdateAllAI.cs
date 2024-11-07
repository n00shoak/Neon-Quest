using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class FOE_General_UpdateAllAI : MonoBehaviour
{
    [SerializeField] private List<FOE_General_Update> EveryAI = new List<FOE_General_Update>();

    private void Update()
    {
        for (int i = 0; i < EveryAI.Count; i++)
        {
            if(EveryAI[i] != null)
            {
                EveryAI[i].CallUpdate();
            }
            else
            {
                EveryAI.RemoveAt(i);
            }
        }
    }
}
