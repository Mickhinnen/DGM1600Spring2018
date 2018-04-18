using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchsandTypes : MonoBehaviour {

	public string UserName;


	// Use this for initialization
	void Start () {
		switch (UserName)
		{
			case "Password": 
				print("Password is correct.");
				break;//break kicks us out, were done.
			case "LevelUp":
				print("You win! Next Level.");
				break;

				default://its the else, but else is reserved for if statements
					print("why don't you tell me which movie you wanna see.");
					break;
			
		}
	}
	
	
}
