using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ZombieMove))]
public class Zombie : MonoBehaviour {
    
    void OnTriggerEnter(Collider col)
    {
        

        if (col.gameObject.GetComponent <Enemy>()){
            Debug.Log(col);
            //ref human
            Enemy enemy = col.gameObject.GetComponent<Enemy>();
            //spawn new zombie
            transform.parent.GetComponentInParent<ZombiesHandler>().AddZombie(enemy.transform.position);
            //destroy human
            enemy.Die();
        }
    }
}
