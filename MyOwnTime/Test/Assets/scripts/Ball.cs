using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

	public MovePattern MovePattern;
	private CharacterController controller;

	void Start () {
		 controller = GetComponent<CharacterController>();
	}
	
	
	void Update () {
		MovePattern.Move(controller, transform);
	}
	void OnTriggerEnter(Collider other)
	{
		print ("Hit " + other);
		AddOther(12);
	}
	void AddOther(float newOther)
	{
		Other += newOther;
	}
}
