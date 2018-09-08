using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour{
    
    [Range (0f, 20f)]
    [SerializeField]
    private float moveSpeed = 3f;
    [Range(50f, 150f)]
    [SerializeField]
    private float rotateSpeed = 100f;

    public void RotateAndMove()
    {
        Rotate();
        Move();
    }

    private void Rotate(){
        if (Input.GetKey(KeyCode.D)) 
        {
            transform.Rotate(Vector3.up * Time.deltaTime * rotateSpeed);
        }
        if (Input.GetKey(KeyCode.A)) 
        {
            transform.Rotate(Vector3.down * Time.deltaTime * rotateSpeed);
        }
    }

    private void Move()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Time.deltaTime * moveSpeed);
        }
    }

}
