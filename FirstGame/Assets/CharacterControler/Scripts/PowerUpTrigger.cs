using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerUpTrigger : MonoBehaviour {

	public PowerUp PowerUpTransfer;
	public float PowerLevel = 0.2;
	public Image HealthBar;
	//public GameObject pickupEffect;
	

   private void OnTriggerEnter(Collider obj)
	{	
		HealthBar.FillAmount += PowerLevel;

		if (HealthBar.FillAmount = 0);
		{
			obj.GetComponent<MoveCharacter>().MovePattern = PowerUpTransfer.Transfer();
		
			gameObject.SetActive(false);
		}
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
