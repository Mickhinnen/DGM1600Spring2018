using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerUpTrigger : MonoBehaviour {

	public PowerUp PowerUpTransfer;
	public float PowerLevel = 0.2F;
	public Image HealthBar;

	public float AddPowerLevel()
	{
		return HealthBar.fillAmount += PowerLevel;
	}		

   private void OnTriggerEnter(Collider obj)
	{	
		PowerLevel = AddPowerLevel;
		obj.GetComponent<MoveCharacter>().MovePattern = PowerUpTransfer.Transfer();
		//if (HealthBar.fillAmount == 0F);
		//	{
		//	obj.GetComponent<MoveCharacter>().MovePattern.StopMove = PowerUpTransfer.Transfer();
		//	}
			gameObject.SetActive(false);
		
	}		

}
