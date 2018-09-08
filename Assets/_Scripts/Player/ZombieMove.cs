using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent (typeof (NavMeshAgent))]
public class ZombieMove : MonoBehaviour {

    NavMeshAgent agent;
    CharacterAnimation anim;

	void Start () {
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<CharacterAnimation>();
	}

    private void Update()
    {
        anim.SetBlendValue(Vector3.Distance(transform.position, transform.parent.position));
        agent.SetDestination(transform.parent.position);
    }

}
