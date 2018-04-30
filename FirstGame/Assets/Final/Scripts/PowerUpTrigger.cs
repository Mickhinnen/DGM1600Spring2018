using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerUpTrigger : MonoBehaviour {

	public PowerUp PowerUpTransfer;
	public float PowerLevel = 1.0F;
	public Image HealthBar;

	public enum PickUp 
		{
			Speedboost, JumpBoost, EnemyHit
		}

		public PickUp CurrentPowerUp;

	public float AddPowerLevel()
	{
		return HealthBar.fillAmount += PowerLevel;
	}		

   private void OnTriggerEnter(Collider obj)
	{	
		obj.GetComponent<MoveCharacter>().Player.MovePattern = PowerUpTransfer.Transfer();
		if (HealthBar.fillAmount > 0F);
			
				PowerLevel = AddPowerLevel();
			
		//	 else

		//		Player.gameObject.SetActive(false);
			
		
		switch (CurrentPowerUp)
					{
						case PickUp.Speedboost :
							print ("you got speed boost");
							break;
						case PickUp.JumpBoost:
							print ("You can now jump");
							break;
						case PickUp.EnemyHit:
							print("you took damage");
							break;

					}

			gameObject.SetActive(false);
		
	}		

}
