using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


/*
 * Author: Clayton
 * 
 * Use Case: When adding functionality unlink prefab by right clicking this component and select the "Relink" function.
 * 
 * Requirements: 
 * - Reference low lvl prefabs in serialized list
 * - Low lvl prefabs have LowLvlPrefab.cs attached
 * - Reference prefab link in each low lvl prefab
 * 
 */
public class ScenePrefab : MonoBehaviour
{

    [SerializeField]
    List<GameObject> LowLvlPrefabs;

    /*
     * Author: Clayton
     * 
     * Use Case: Scene prefabs was just added to scene or reverted: 
     * This relinks any object with a PrefabLink component
     * 
     */
    [ContextMenu("Relink LowLvl Prefabs")]
    void LinkPrefabs()
    {

        //disconnect high level prefab
        PrefabUtility.DisconnectPrefabInstance(gameObject);

        int i = 0;

        //cycly through and relink low lvl prfabs
        foreach (GameObject obj in LowLvlPrefabs)
        {

            //cache references for when obj is destroyed
            GameObject newObj = null;

            Vector3 objPos = obj.transform.position;
            Quaternion objRot = obj.transform.rotation;

            GameObject prefabLink = (GameObject)obj.GetComponent<PrefabLink>().prefabLink;
            Debug.Log(prefabLink);

            try
            {
                //relink prefab (destroys current obj)
                newObj = PrefabUtility.ConnectGameObjectToPrefab(obj, prefabLink);
            }
            catch
            {
                Debug.LogError("Error linking Gameobject " + name + " to prefab " + prefabLink); //+ ":" + e.Message);
            }

            //reset to correct orientation
            newObj.transform.position = objPos;
            newObj.transform.rotation = objRot;

            //re-reference prefabLink Objects
            LowLvlPrefabs[i] = newObj;
            i++;

        }

    }


}