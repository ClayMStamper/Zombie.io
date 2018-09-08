using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    PlayerMove movement;
    PlayerGrowth growth;

    private void Start()
    {
        Setup();
    }

    private void Update()
    {

        movement.RotateAndMove();

    }

    private void Setup(){
        movement = GetComponent<PlayerMove>();
        growth = GetComponent<PlayerGrowth>();
    }

}
