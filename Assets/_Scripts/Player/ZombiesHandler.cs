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

        newZom.transform.parent = transform;
        zombies.Add(newZom);

        Camera.main.transform.localPosition += new Vector3(0, 1, -1);

    }
    public void AddZombie()
    {

        GameObject newZom = Instantiate(zombiePrefab,
                                        transform.parent.position,
                                        Quaternion.identity,
                                        transform.parent) as GameObject;

        newZom.transform.parent = transform;
        zombies.Add(newZom);
        Camera.main.transform.localPosition += new Vector3(0, 1, -1);

    }

}
