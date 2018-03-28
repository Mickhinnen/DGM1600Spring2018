using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBase : MonoBehaviour {

public float Speed;

	void OnTriggerEnter(Collider other)
	{
		print ("hit " + other);
		
	}
}
