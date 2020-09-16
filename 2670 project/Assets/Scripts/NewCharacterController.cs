using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(CharacterController))]

public class NewCharacterController : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 movement;

    public float moveSpeed = 5f, rotateSpeed = 120f, gravity = -9.81f;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    private void Update()
    {
        var vInput = Input.GetAxis("Vertical")*moveSpeed;
        movement.Set(vInput,gravity,0 );

        var hInput = Input.GetAxis("Horizontal")*Time.deltaTime*rotateSpeed;
        transform.Rotate(0,hInput,0);

        movement = transform.TransformDirection(movement);
        
        controller.Move(movement * Time.deltaTime);
    }
}
