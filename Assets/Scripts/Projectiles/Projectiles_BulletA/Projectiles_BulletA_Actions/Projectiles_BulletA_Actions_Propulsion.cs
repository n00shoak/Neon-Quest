using UnityEngine;

public class Projectiles_BulletA_Actions_Propulsion : MonoBehaviour
{
    private Rigidbody rb;
    private Projectiles_General_LifeTime lifeTime;

    public void BulletUpdate()
    {
        // do stuff
    }

    public void SetStats(Vector3 _baseVelocity, float _speed = 1,float _drag = 0,float _lifeTime = 3)
    {
        lifeTime = GetComponent<Projectiles_General_LifeTime>();

        rb = GetComponent<Rigidbody>();
        rb.linearVelocity = _baseVelocity + transform.up * _speed;
        rb.linearDamping = _drag;
        gameObject.AddComponent<Projectiles_General_LifeTime>();
        gameObject.GetComponent<Projectiles_General_LifeTime>().lifeTime = _lifeTime;

        lifeTime.updateBullet.AddListener(BulletUpdate);
    }

}
