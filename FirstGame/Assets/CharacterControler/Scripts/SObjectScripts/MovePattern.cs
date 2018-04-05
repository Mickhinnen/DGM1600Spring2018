using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class MovePattern : ScriptableObject {

	public float speed = 20.0F;
    public float jumpSpeed = 20.0F;
    public float gravity = 20.0F;
	private Vector3 moveDirection = Vector3.zero;

    public InputBase InputX;
    public InputBase InputY;
    public InputBase InputZ;

public void Move (CharacterController controller, Transform Mytransform)
{
	 if (controller.isGrounded) {
			moveDirection.x = InputX.SetFloat();
            moveDirection.y = InputY.SetFloat();
			moveDirection.z = InputZ.SetFloat();
            moveDirection = Mytransform.TransformDirection(moveDirection);
            moveDirection *= speed;
            if (Input.GetButton("Jump"))//bool.. boolean variable
                moveDirection.y = jumpSpeed;
            
        }
        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move (moveDirection * Time.deltaTime);
	}
}
