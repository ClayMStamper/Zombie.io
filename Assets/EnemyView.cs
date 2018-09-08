using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyView : MonoBehaviour
{
    private void OnTriggerEnter(Collider col)
    {
        //consider refactoring literal 
        //9 is the interger value of the zombie layer
        if(col.gameObject.layer == 9){

            Debug.Log("hit zomb");

            //ref human obj
            Enemy enemy = transform.parent.GetComponent<Enemy>();
            //tell human about the player
            enemy.movement.knowsAboutPlayer = true;
        }
    }

    private void OnTriggerExit(Collider col)
    {
        //consider refactoring literal 
        //9 is the interger value of the zombie layer
        if (col.gameObject.layer == 9)
        {

            Debug.Log("Left zomb... back to idle");

            //ref human obj
            Enemy enemy = transform.parent.GetComponent<Enemy>();
            //tell human about the player
            enemy.movement.knowsAboutPlayer = false;
        }
    }

}