using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacter : MonoBehaviour {

    public MovePattern MovePattern;
	private CharacterController controller;
	public int Health = 20;
	
	private void Start ()
	{
	  controller = GetComponent<CharacterController>();	
	}
    void Update() {
       MovePattern.Move (controller, transform);       
    }
	

}	

