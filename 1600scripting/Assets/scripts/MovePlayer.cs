﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{

    private CharacterController controller;
    private Vector3 newPosition;

    public float Speed = 10.0f;
    public float Gravity = 3f;
    public float JumpHeight = 100.0f;
    public bool CanRun = true;

	// Use this for initialization
	void Start ()
    {
        controller = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Space) && controller.isGrounded)
        {
            newPosition.y = JumpHeight;
        }

        if (CanRun)
        {
            newPosition.x = Speed * Input.GetAxis("Horizontal");
            newPosition.z = Speed * Input.GetAxis("Vertical");
        }
        newPosition.y -= Gravity;
        controller.Move(newPosition * Time.deltaTime);
	}
}
