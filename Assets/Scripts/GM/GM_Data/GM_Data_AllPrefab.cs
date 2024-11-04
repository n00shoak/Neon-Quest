using UnityEngine;

public class GM_Data_AllPrefab : MonoBehaviour
{
    public GameObject[] projectiles;
    public GameObject[] particles;



    public void getAllPrefabs()
    {
        projectiles = Resources.LoadAll<GameObject>("Prefabs/Projectiles");
        particles = Resources.LoadAll<GameObject>("Prefabs/Particles");
    }
}