﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public Transform target;

    [Range(0, 1)]
    public float smoothSpeed = 0.125f;
    public Vector3 offset;
    public Vector2 mapEdgeBumper;

    void Start()
    {
        target = Player.GetInstance().transform;
    }

    void LateUpdate()
    {
        UpdateCameraPos();
    }

    void UpdateCameraPos()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, Time.deltaTime * smoothSpeed);
     //   smoothedPosition.x = Mathf.Clamp(smoothedPosition.x, -mapSize.x / 2 + mapEdgeBumper.x, mapSize.x / 2 - mapEdgeBumper.x);
       // smoothedPosition.z = Mathf.Clamp(smoothedPosition.z, -mapSize.y / 2 + mapEdgeBumper.y, mapSize.y / 2 - mapEdgeBumper.y);
        transform.position = smoothedPosition;
        transform.LookAt(target);
    }

}
