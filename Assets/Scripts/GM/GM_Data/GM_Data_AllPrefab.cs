using UnityEngine;

public class GM_Data_AllPrefab : MonoBehaviour
{
    public GameObject[] projectiles;


    public void getAllPrefabs()
    {
        projectiles = Resources.LoadAll<GameObject>("Prefabs/Projectiles");
    }
}