using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerUpTrigger : MonoBehaviour {

	public PowerUp PowerUpTransfer;
	public float PowerLevel = 1.0F;
	public Image HealthBar;

	public float AddPowerLevel()
	{
		return HealthBar.fillAmount += PowerLevel;
	}		

   private void OnTriggerEnter(Collider obj)
	{	
		obj.GetComponent<MoveCharacter>().Player.MovePattern = PowerUpTransfer.Transfer();
		if (HealthBar.fillAmount > 0F);
			{
				PowerLevel = AddPowerLevel();
			}
			gameObject.SetActive(false);
		
	}		

}
