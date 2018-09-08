using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class EnemyMove : MonoBehaviour
{
    Vector3 startPos;

    private NavMeshAgent agent;
    public bool knowsAboutPlayer = false;
    protected Vector3 target;

    bool idling;

    public virtual void SetTarget()
    {
        Debug.Log("should be setting target");
        if (!idling)
        {
            StartCoroutine(Idle());
        }
    }

    public void Move()
    {
        Debug.Log("Moving");
        agent.SetDestination(target);
    }

    public void Setup()
    {
        Debug.Log("Setting up : " + name);
        startPos = transform.position;
        agent = GetComponent<NavMeshAgent>();
    }

    public IEnumerator Idle()
    {
        Debug.Log("idle");
        idling = true;

        while (!knowsAboutPlayer)
        {
            target = SetRandomTarget();
            yield return new WaitForSeconds(Random.Range(2, 7));
        }

        idling = false;
        Debug.Log("no longer idling");
        yield return null;
    }

    Vector3 SetRandomTarget()
    {
        Vector3 offset = new Vector3(Random.Range(-5, 5), Random.Range(-5, 5), Random.Range(-5, 5));
        return startPos + offset;
    }

}
