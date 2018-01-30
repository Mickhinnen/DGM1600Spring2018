using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Class is an object classification
//You must have and closed per object
//void is a function that is empty or null
public class SecondLevel : MonoBehaviour {

	// Use this for initialization
	public bool key = false;
		
		void OnMouseDown()
		{
			if(key == true)
			{ print("open door");
			}
			if(key == false)
			{ print("Door is locked");
			}
		}
}
