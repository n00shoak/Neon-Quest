using UnityEngine;
using NaughtyAttributes;

public class Player_Data_Stats : MonoBehaviour
{
    public Player_Data_StatsSO defaultData;
    public Player_Data_StatsSO[] bonusData;

    [HideInInspector]public Stats currentStats;

    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();

        UpdateStats();
    }

    [NaughtyAttributes.Button]
    public void UpdateStats()
    {
        currentStats = new Stats();
        currentStats = defaultData.SetStats(currentStats);

        for(int i = 0; i < bonusData.Length; i++)
        {
            if(bonusData[i].isMultiplier)
            {
                currentStats = bonusData[i].multiplyStats(currentStats);
            }
            else
            {
                currentStats = bonusData[i].AddStats(currentStats);
            }
        }

        ApplyCompenentsStats();
    }

    private void ApplyCompenentsStats()
    {
        rb.linearDamping = currentStats.friction;
    }
}