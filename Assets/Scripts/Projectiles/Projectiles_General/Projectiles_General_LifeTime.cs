using System;
using UnityEngine;
using UnityEngine.Events;

public class Projectiles_General_LifeTime : MonoBehaviour
{
    public float lifeTime;
    public UnityEvent updateBullet;

    public static implicit operator UnityEvent(Projectiles_General_LifeTime v)
    {
        throw new NotImplementedException();
    }
}
