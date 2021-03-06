﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class MovePattern : ScriptableObject {

	public float speed = 6.0F;
	public float jumpspeed = 8.0F;
	public float gravity = 20.0F;
	private Vector3 moveDirection = Vector3.zero;

	public void Move(CharacterController controller, Transform transform)
	{
		moveDirection.x = Input.GetAxis("Horizontal");
		
		if (controller.isGrounded){
		
		moveDirection.y = 0;
		moveDirection.z = Input.GetAxis("Vertical");
		moveDirection = transform.TransformDirection(moveDirection);
		moveDirection *= speed;
		if (Input.GetButton("Jump"))
			moveDirection.y = jumpspeed;
		}
	
	moveDirection.y -= gravity * Time.deltaTime;
	controller.Move (moveDirection * Time.deltaTime);
	}
}
