using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunctionsWithPeramtier : MonoBehaviour {

	public int Health = 20;

	 void OnTriggerEnter(Collider other)//not key, collision. other can be anything
	{
		print("Hit " + other);
		
		AddHealth(25);

	}

	void AddHealth(int newHealth)
	{
		Health += newHealth;
	}
}
