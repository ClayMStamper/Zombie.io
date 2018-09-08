using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour{

    public float moveSpeed = 2f;
    public float rotateSpeed = 2f;

    public void RotateAndMove()
    {
        Rotate();
        Move();
    }

    private void Rotate(){
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.down * Time.deltaTime * rotateSpeed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * Time.deltaTime * rotateSpeed);
        }
    }

    private void Move(){
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);
        }
    }

}
