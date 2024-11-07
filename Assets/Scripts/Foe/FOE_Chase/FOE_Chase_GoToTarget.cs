using UnityEngine;
using UnityEngine.AI;

public class FOE_Chase_GoToTarget : MonoBehaviour
{
    public Transform target;

    private NavMeshAgent agent;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        target = GameObject.Find("Player").transform;
    }

    private void Update()
    {
        agent.destination = target.position;
    }
}
