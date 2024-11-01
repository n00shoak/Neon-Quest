using UnityEngine;

public class Projectiles_BulletA_Actions_Propulsion : MonoBehaviour
{
    private Rigidbody rb;

    public void SetStats(float speed = 1,float drag = 0,float lifeTime = 3)
    {
        rb.linearVelocity = transform.up * speed;
        rb.linearDamping = drag;
    }

    
}
