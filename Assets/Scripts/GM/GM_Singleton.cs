using UnityEngine;

public class GM_Singleton : MonoBehaviour
{

    private static GM_Singleton instance = null;
    public static GM_Singleton Instance => instance;

    public GM_Data_AllPrefab Prefabs;

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }

    private void Start()
    {
        Prefabs = GetComponent<GM_Data_AllPrefab>();
        Prefabs.getAllPrefabs();
}
}
