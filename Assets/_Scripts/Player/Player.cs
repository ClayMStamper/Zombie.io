using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof (PlayerMove))]
[RequireComponent(typeof(ZombiesHandler))]
public class Player : MonoBehaviour {

    #region singleton

    private static Player instance;

    private void Awake()
    {
        if (instance == null){
            instance = this;
        } else {
            Destroy(gameObject);
        }
    }

    public static Player GetInstance(){
        return instance;
    }

    #endregion

    PlayerMove movement;
    ZombiesHandler zombies;

    int zombieLayer = 9;

    private void Start()
    {
        Setup();
    }

    private void Update()
    {

        movement.RotateAndMove();

    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.layer == zombies.layer){
            
        }   
    }

    private void Setup(){
        movement = GetComponent<PlayerMove>();
        zombies = GetComponent<ZombiesHandler>();
    }

}
