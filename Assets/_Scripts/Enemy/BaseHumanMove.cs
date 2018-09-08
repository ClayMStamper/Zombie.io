using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseHumanMove : EnemyMove {

    public override void SetTarget()
    {
        base.SetTarget();

        if (knowsAboutPlayer)
        {
            target = CalcOppDir();
        }

    }
    public Vector3 CalcOppDir()
    {

        GameObject playerObject = GameObject.Find("Player");
        Vector3 heading = transform.position - playerObject.transform.position;
        return heading;

    }

    
}
