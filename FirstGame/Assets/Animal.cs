using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour {

	// Use this for initialization
	// This declares what start will do
	void Start () {
		print("my animal is eating.");
		print("Now my animal is sleeping");
		//print does not exsist with a capital P, it must be lower case.
		//idicates notes, and indicates for the computer to ignore it.
		// this () indicates a function, must have "" for a string of txt.
		// this {} is an object.
		// print is a function call.
		// this ; is a period, ends a line of txt.
		print("I love mt cat.");
	}
	void OnMouseDown()
	{
		print("meow");
	}
	// Update is called once per frame
	void Update () {
		
	}
}