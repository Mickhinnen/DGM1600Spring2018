using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpTrigger : MonoBehaviour {

	public PowerUp PowerUpTransfer;
	//public MovePattern PowerUp;

	//public GameObject pickupEffect;
	

   private void OnTriggerEnter(Collider obj)
	{	
		obj.GetComponent<MoveCharacter>().MovePattern = PowerUpTransfer.Transfer();

		/*if (other.CompareTag("Player"))
		{
			StartCoroutine(Pickup(other));
		}*/
	}		
	
/*	IEnumerator Pickup(Collider Player)
		{
			print("You hit ");

			Instantiate(pickupEffect, transform.position, transform.rotation);

			//effect	

			Destroy(gameObject);
		}
*/	

}
