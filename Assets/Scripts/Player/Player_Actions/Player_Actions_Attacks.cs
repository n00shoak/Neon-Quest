using Unity.VisualScripting;
using UnityEngine;

public class Player_Actions_Attacks : MonoBehaviour
{
    private Stats stats;
    private GameObject bulletHolder;
    private Rigidbody rb;


    private void Start()
    {
        rb = GetComponent<Rigidbody>();

        stats = GetComponent<Player_Data_Stats>().currentStats;
        bulletHolder = GameObject.Find("BulletHolder");
    }

    // SpreadShooting
    public void ShootBulletA()
    {
        GameObject bullet = GM_Singleton.Instance.Prefabs.projectiles[0];

        for (int i = 0;i < 1 + stats.multishot + 2;i++)
        {
            GameObject instance = Instantiate(bullet);
            instance.transform.parent = bulletHolder.transform;
            instance.transform.localScale = Vector3.one * (1 + stats.areaOfEffect);
            instance.transform.position = transform.position;
            instance.transform.eulerAngles = 
                transform.eulerAngles + 
                (Vector3.forward * (10 * i) - Vector3.forward * (1 + stats.multishot)/2) + 
                Vector3.forward * -90;

            bulletHolder.GetComponent<Projectiles_BulletHolder_BulletsLifeTime>().everyLifeTime.Add(instance.GetComponent<Projectiles_General_LifeTime>());

            Projectiles_BulletA_Actions_Propulsion bulletPropeller = instance.GetComponent<Projectiles_BulletA_Actions_Propulsion>();
            bulletPropeller.SetStats(30 + stats.projectileSpeed + (rb.linearVelocity.normalized).magnitude,0, 0.5f + stats.duration);
        }
    }
}