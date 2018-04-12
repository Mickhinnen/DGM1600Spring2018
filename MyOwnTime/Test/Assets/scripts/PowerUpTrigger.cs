using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpTrigger : MonoBehaviour {

	public PowerUp PowerUpTransfer;
	private MovePattern prevMovePattern;
	

	private void OnTriggerEnter( Collider obj)
	{
		prevMovePattern = obj.GetComponent<Ball>().MovePattern;

		obj.GetComponent<Ball>().MovePattern = PowerUpTransfer.Transfer();
		
		gameObject.SetActive (false);
	}
}
