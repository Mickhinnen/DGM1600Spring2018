using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSwitch : MonoBehaviour {

public PowerUpBase MyPowerUp;

	// Use this for initialization
	void Start () {
		switch (MyPowerUp.name)
		{
			case "Ammo":
			print("You got ammo");
			break;
		}		
	}
	

}
