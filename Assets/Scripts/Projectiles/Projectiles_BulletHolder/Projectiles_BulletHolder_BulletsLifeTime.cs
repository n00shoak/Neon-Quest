using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectiles_BulletHolder_BulletsLifeTime : MonoBehaviour
{
    public List<Projectiles_General_LifeTime> everyLifeTime;
    [SerializeField]private List<Projectiles_General_LifeTime> everyCurrentLifeTime;

    public float timeSpeed = 0.1f;
    public bool UpdateLifeTime = true;

    void Start()
    {
        StartCoroutine(UpdateAllLifeTime());
    }

    public IEnumerator UpdateAllLifeTime()
    {
        while (UpdateLifeTime)
        {
            for (int i = everyCurrentLifeTime.Count - 1; i >= 0; i--) // Loop backwards to safely remove items
            {
                if (everyCurrentLifeTime[i] == null)
                {
                    everyCurrentLifeTime.RemoveAt(i); // Clean up any null entries
                    continue;
                }

                everyCurrentLifeTime[i].lifeTime -= timeSpeed;
                everyCurrentLifeTime[i].updateBullet.Invoke();
                if (everyCurrentLifeTime[i].lifeTime <= 0)
                {
                    Destroy(everyCurrentLifeTime[i].gameObject);
                    everyCurrentLifeTime.RemoveAt(i); // Remove from list after destroying
                }
            }

            for(int i = everyLifeTime.Count -1; i >= 0; i--)
            {
                everyCurrentLifeTime.Add(everyLifeTime[i]);
            }
            everyLifeTime.Clear();

            yield return new WaitForSeconds(timeSpeed); // Wait before next update
        }
    }
}
