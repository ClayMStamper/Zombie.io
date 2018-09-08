using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMove : MonoBehaviour
{

    public Camera cam;

    public NavMeshAgent agent;

    private Vector3 target;

    protected virtual void SetTarget(){
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                target = hit.point;
            }
        }
    }

    public void Move()
    {
        agent.SetDestination(target);
    }

}
