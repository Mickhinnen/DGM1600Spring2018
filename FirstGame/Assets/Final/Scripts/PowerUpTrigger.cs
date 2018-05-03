using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerUpTrigger : MonoBehaviour {

	public PowerUp PowerUpTransfer;
	public float PowerLevel = 1.0F;
	public Image HealthBar;
	public Player MyPlayer;
	public int Coins = 0;
	public int FoundCoins = 1;
//	public GameObject Player1;

	[SerializeField]
	private Color Green;

	[SerializeField]
	private Color Red;

	public enum PickUp 
		{
			Speedboost, JumpBoost, EnemyHit, ReverseGravity
		}

	public PickUp CurrentPowerUp;

		public float AddPowerLevel()
			{
				return HealthBar.fillAmount += PowerLevel;
			}		
		
		public int AddCoins()
		{
			return Coins += FoundCoins;
		}

	public void start()
    {
         		 
		 string[] CoinTypes = new string [3];

        CoinTypes[0] = "Regular Coin find all 20";
        CoinTypes[1] = "Large Coin worth 2 find all 3";
        CoinTypes[2] = "Mega Coin worth 4, theres only 1";

        foreach(string item in CoinTypes)
        {
           print(item);
        }

		 for (int i = 90; i > 0; i --)
				{
					print(i + "seconds left");
				}//i was trying to make a timer...

    }

	
		private void OnTriggerEnter(Collider obj)
		{
		//	while (/*Player.Coins != 30 &&*/ HealthBar.fillAmount != 0F) DON"T TOUCH CRASHES UNITY
		//	{	
				obj.GetComponent<MoveCharacter>().Player.MovePattern = PowerUpTransfer.Transfer();
				if (HealthBar.fillAmount > 0F)
					{
					PowerLevel = AddPowerLevel();
					} else {
						//gameObject.Player.SetActive(false);
						print("Game Over");
					}
					
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
						case PickUp.ReverseGravity:
							print("Gravity is gone");
							break;
					}

					if (HealthBar.fillAmount >= .4F)
						{
							HealthBar.color = Color.green;
						} else
							{ HealthBar.color = Color.red; }

				gameObject.SetActive(false);

				
		//	} //once while loop works end game when life hits 0 or all coins are found
		}

	/*	void update()				wont get here till I get while loop working
		{
			if (HealthBar.fillAmount <= 0F)
		//	GameObject.FindGameObjectWithTag ("Player");
			print("Game Over");	
		}*/
	}
