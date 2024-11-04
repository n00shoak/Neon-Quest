using System.Collections;
using UnityEngine;
using static UnityEngine.ParticleSystem;

public class Player_Actions_Spells : MonoBehaviour
{
    [SerializeField] private Player_VFX_PlayParticles particles;

    private Stats stats;
    private GameObject bulletHolder;
    private Rigidbody rb;

    private bool playingRush;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();

        stats = GetComponent<Player_Data_Stats>().currentStats;
        bulletHolder = GameObject.Find("BulletHolder");
    }

    public void Rush()
    {
        if(!playingRush)
        {
            playingRush = true;
            StartCoroutine(PlayRush(0.5f + stats.duration / 4));
        }
        
    }

    IEnumerator PlayRush(float timer)
    {
        particles.PlayExplosion(transform.position);

        Player_Acions_DefaultMovement movement = GetComponent<Player_Acions_DefaultMovement>();
        float friction = rb.linearDamping;

        rb.linearDamping = 0.0f;
        movement.enabled = false;

        rb.linearVelocity = transform.right * 100 + transform.right * stats.projectileSpeed / 4;
        yield return new WaitForSeconds(timer);

        rb.linearDamping = friction;
        movement.enabled = true;
        playingRush = false;
    }
}
