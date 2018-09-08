using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombiesHandler : MonoBehaviour {

    //zombies collision layer
    public int layer = 9;

    [SerializeField]
    Object zombiePrefab;
    public List<GameObject> zombies;

    public void AddZombie(Vector3 spawnPos){

        GameObject newZom = Instantiate(zombiePrefab,
                                        spawnPos,
                                        Quaternion.identity,
                                        transform.parent) as GameObject;

        zombies.Add(newZom);

    }
    public void AddZombie()
    {

        GameObject newZom = Instantiate(zombiePrefab,
                                        transform.parent.position,
                                        Quaternion.identity,
                                        transform.parent) as GameObject;

        zombies.Add(newZom);
    }

}
