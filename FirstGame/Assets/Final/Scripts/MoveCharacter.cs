using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacter : MonoBehaviour {

    public Player Player;
	//public PowerUpTrigger PowerLevel;
	private CharacterController controller;
	
	
	private void Start ()
	{
	  controller = GetComponent<CharacterController>();	
	}
    void Update() {
       Player.MovePattern.Move (controller, transform);  

	  // if(PowerLevel = 0F);
	  // {
		//   gameObject.SetActive(false);
	   //}

    }
	

}	

