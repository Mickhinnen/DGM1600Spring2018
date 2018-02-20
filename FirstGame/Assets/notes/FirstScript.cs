using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour {
 public int A;
 public int B;
 public string Password;
	// Use this for initialization
	void OnMouseDown()
	{
	 	
	if ( A == B )
	{
	print("Match");
	} 	
	if ( A > B )
	{
		print("Too much");
	}
	if (A < B )
	{
		print("Too little");
	}
	if ( A == B && Password == "Avada Kadava")
	{
		print("Game Over");
	}
	if ( A == B && Password == "Opensesame")
	{
		print("Door unlocked");
	} 
	//+= means plus to assigned value
	}
}