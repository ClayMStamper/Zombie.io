using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent (typeof (NavMeshAgent))]
public class ZombieMove : MonoBehaviour {

    NavMeshAgent agent;

	void Start () {
        agent = GetComponent<NavMeshAgent>();
	}

    private void Update()
    {
        agent.SetDestination(transform.parent.position);
    }

}
