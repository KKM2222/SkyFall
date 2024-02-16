using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    public bool LeftMove = false;
    public bool RightMove = false;
    Vector3 moveVelocity = Vector3.zero;
    float moveSpeed = 10;

    void Update()
    {
        if(LeftMove) 
        {
            moveVelocity = new Vector3(-0.10f, 0, 0);
            transform.position += moveVelocity * moveSpeed * Time.deltaTime;
        }
        if(RightMove)
        {
            moveVelocity = new Vector3(+0.10f, 0, 0);
            transform.position += moveVelocity * moveSpeed * Time.deltaTime;
        }
    }
}
