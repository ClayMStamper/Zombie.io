using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class EnemyMove : MonoBehaviour
{
    Vector3 startPos;

    private NavMeshAgent agent;
    public bool knowsAboutPlayer;
    protected Vector3 target;


    public void Setup(){
        startPos = transform.position;
        agent = GetComponent<NavMeshAgent>();
    }

    public virtual void SetTarget()
    {
        if (!knowsAboutPlayer){
           // StartCoroutine(Idle());
         //   return;
        }
        //inherited class is called now
    }

    public void Move()
    {
        agent.SetDestination(target);
    }

    Vector3 SetRandomTarget()
    {
        Vector3 offset = new Vector3(Random.Range(-5, 5), Random.Range(-5, 5), Random.Range(-5, 5));
        return startPos + offset;
    }

    IEnumerator Idle()
    {
        knowsAboutPlayer = true;

        while (knowsAboutPlayer)
        {
            target = SetRandomTarget();
            yield return new WaitForSeconds(Random.Range(2, 7));
        }

        yield return null;
    }

}
