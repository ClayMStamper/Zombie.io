using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    PlayerMove move;

    private void Start()
    {
        Setup();
    }

    private void Update()
    {

        move.RotateAndMove();

    }

    private void Setup(){
        move = GetComponent<PlayerMove>();
    }

}
