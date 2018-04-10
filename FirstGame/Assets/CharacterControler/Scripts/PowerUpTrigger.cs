using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpTrigger : MonoBehaviour {

	public PowerUp PowerUpTransfer;
	private MovePattern prevMovePattern;
	//public GameObject pickupEffect;
	

   private void OnTriggerEnter(Collider obj)
	{	
		prevMovePattern = obj.GetComponent<MoveCharacter>().MovePattern

		obj.GetComponent<MoveCharacter>().MovePattern = PowerUpTransfer.Transfer();
		

		
		gameObject.SetActive(false);
		/*if (other.CompareTag("Player"))
		{
			StartCoroutine(Pickup(other));
		}*/
	}		
	
	void RestoreMovePattern(MovePattern oldMovePattern)
	{
		
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
