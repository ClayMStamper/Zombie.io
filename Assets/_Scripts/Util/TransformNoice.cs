using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformNoice : MonoBehaviour {

    [SerializeField]
    [Tooltip("How much the transforms will be randomly shifted (in world units)")]
    float magnitude = 0.01f;

    [ContextMenu("Add Pos Noise")]
    public void Move()
    {

        Vector3 newpos = transform.position;

        newpos += new Vector3(
            Random.Range(-magnitude, magnitude),
            Random.Range(-magnitude, magnitude),
            Random.Range(-magnitude, magnitude));

        transform.position = newpos;

    }
}
