using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(EnemyMove))]
public class Enemy : MonoBehaviour {

    EnemyMove movement;

	// Use this for initialization
	void Start () 
    {
        SetUp();
	}
	
	// Update is called once per frame
	void Update () 
    {
        movement.SetTarget();
        movement.Move();
	}

    void SetUp()
    {
        movement = GetComponent<EnemyMove>();
        movement.Setup();
    }

    public void die()
    {
        Destroy(gameObject);
    }
}
