using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rig;
    float jumpForce = 680f; //มกวม
    float walkForce = 30f;
    float maxWalkSpeed = 2f;
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) 
        {
        rig.AddForce(transform.up *  jumpForce);
        }
    }
    int key = 0;

}
