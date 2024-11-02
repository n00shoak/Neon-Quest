using UnityEngine;

public class Projectiles_BulletA_Actions_Propulsion : MonoBehaviour
{
    private Rigidbody rb;

    public void SetStats(float _speed = 1,float _drag = 0,float _lifeTime = 3)
    {
        rb = GetComponent<Rigidbody>();
        rb.linearVelocity = transform.up * _speed;
        rb.linearDamping = _drag;
        gameObject.AddComponent<Projectiles_General_LifeTime>();
        gameObject.GetComponent<Projectiles_General_LifeTime>().lifeTime = _lifeTime;
    }
}
