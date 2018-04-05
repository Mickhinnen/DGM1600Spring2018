using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpTriggerBase : MonoBehaviour {

	public float multiplier = 1.5F;

	public gameObject pickupEffect
	

   void OnTriggerEnter(Collider other)
	{

		if (other.CompareTag("Player"))
		{
			Pickup();
		}
	}		
	
	void Pickup(Collider Player)
		{
			print("You hit " + other);

			Instantiate(pickupEffect, transform.position, transform.rotation);

			player.transform.localspeed *= multiplier;	

			Destroy(gameObject);
		}
	

}
