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
        GameObject bulletPrefab = GM_Singleton.Instance.Prefabs.projectiles[0];
        int totalShots = Mathf.RoundToInt(3 + stats.multishot);
        float spreadAngle = 30f;  // Adjust as needed or dynamically with stats.multishot

        for (int i = 0; i < totalShots; i++)
        {
            GameObject bulletInstance = Instantiate(bulletPrefab);
            bulletInstance.transform.parent = bulletHolder.transform;
            bulletInstance.transform.localScale = Vector3.one * (1 + stats.areaOfEffect);

            // Set the bullet position in an arc
            bulletInstance.transform.position = GetPositionOnCircle(
                transform.position, 4 , spreadAngle, totalShots, i
            );

            // Calculate and set rotation for the bullet
            float angleOffset = (10 * i - (1 + stats.multishot) * 5);
            bulletInstance.transform.eulerAngles = transform.eulerAngles + Vector3.forward * angleOffset - Vector3.forward * 90;

            // Add bullet to tracking for lifetime management
            bulletHolder.GetComponent<Projectiles_BulletHolder_BulletsLifeTime>().everyLifeTime.Add(
                bulletInstance.GetComponent<Projectiles_General_LifeTime>()
            );

            // Set bullet propulsion stats
            Projectiles_BulletA_Actions_Propulsion bulletPropeller = bulletInstance.GetComponent<Projectiles_BulletA_Actions_Propulsion>();
            bulletPropeller.SetStats(
                rb.linearVelocity,
                30 + stats.projectileSpeed,
                0,
                0.5f + stats.duration
            );
        }
    }

    public Vector3 GetPositionOnCircle(Vector3 center, float diameter, float angle, int totalPoints, int currentPointIndex)
    {
        float radius = diameter / 2f;
        float angleStep = angle / (totalPoints - 1);
        float currentAngle = -angle / 2 + currentPointIndex * angleStep;
        float radianAngle = currentAngle * Mathf.Deg2Rad;

        // Calculate the position on the circle before applying rotation
        Vector3 localPosition = new Vector3(Mathf.Cos(radianAngle), Mathf.Sin(radianAngle), 0) * radius;

        // Apply the object's rotation to align the circle with the object's orientation
        Vector3 rotatedPosition = center + transform.rotation * localPosition;

        return rotatedPosition;
    }
}