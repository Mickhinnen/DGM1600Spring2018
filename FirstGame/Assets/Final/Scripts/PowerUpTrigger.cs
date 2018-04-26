using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerUpTrigger : MonoBehaviour {

	public PowerUp PowerUpTransfer;
	public float PowerLevel = 1.0F;
	public Image HealthBar;

	enum HealthColor 
		{
			Green, Yellow, Red
		};

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
		/*Switch (HealthColor)
		{
			case PowerLevel >= .8F:
				HealthBar.material.color = Color.green;
				break;
			case PowerLevel >= .4F:
				HealthBar.material.color = Color.yellow;
				break;
			case PowerLevel >= .1F:
				HealthBar.material.color = Color.red;
				break;
			
		}*/
	}		

}
