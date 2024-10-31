using UnityEngine;

public class FollowTarget : MonoBehaviour
{
    [SerializeField] private Transform target;
    void Update()
    {
        transform.position = target.position;
    }
}
