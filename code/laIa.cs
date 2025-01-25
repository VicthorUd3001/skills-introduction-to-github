using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class laIa : MonoBehaviour
{
    private NavMeshAgent agent;
    public Transform player;
    public float speed = 30;
    private Transform currDest;
    public int i;
    private bool canHunt;
    public List<Transform> patrolPoints;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.speed = speed;
        currDest = transform;
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            canHunt = true;
            currDest = player;
        }
    }
    public void OnTriggerExit(Collider other)
    {
        canHunt = false;
        currDest = transform;
    }
    void Update()
    {
        transform.LookAt(agent.steeringTarget);

        if (canHunt)
        {
            Debug.Log("canhunt");
            agent.destination = currDest.position;
            return;
        }
        if (!agent.pathPending && agent.remainingDistance < 0.25f)
        {
            Debug.Log("patrolling");
            agent.destination = patrolPoints[i].position;
            i = (i + 1) % patrolPoints.Count;
        }
    }
}
