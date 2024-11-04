using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class Player_VFX_PlayParticles : MonoBehaviour
{
    public void PlayExplosion(Vector3 _position = new Vector3())
    {
        GameObject burstInstance = Instantiate(GM_Singleton.Instance.Prefabs.particles[0]);
        burstInstance.transform.parent = GameObject.Find("FX").transform;
        burstInstance.transform.localPosition = _position;
        burstInstance.transform.localScale = Vector3.one * 1.5f;


        GameObject shockwaveInstace = Instantiate(GM_Singleton.Instance.Prefabs.particles[1]);
        shockwaveInstace.transform.parent = GameObject.Find("FX").transform;
        shockwaveInstace.transform.localPosition = _position;
        shockwaveInstace.transform.localScale = Vector3.one * 2;

        ParticleSystem burst = burstInstance.GetComponent<ParticleSystem>();
        burst.Play();

        ParticleSystem shockwave = shockwaveInstace.GetComponent<ParticleSystem>();
        shockwave.Play();

        StartCoroutine(destroyInstances(0.5f, burstInstance));
        StartCoroutine(destroyInstances(0.5f, shockwaveInstace));
    }

    private IEnumerator destroyInstances(float timer, GameObject toDestroy)
    {

        yield return new WaitForSeconds(timer);
        Destroy(toDestroy);

    }
}