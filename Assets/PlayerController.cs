using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    public NavMeshAgent agent;
    public GameObject target;
    
    void Update()
    {
        agent.SetDestination(target.transform.position);

    }
}
