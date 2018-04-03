using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTrigger : MonoBehaviour {
public Player MyPlayer;
public float speed;
	void OnTriggerEnter()
		{
			AddSpeed(speed);
		}
	void AddSpeed(PowerUp powerup)
	{
		print(powerUp.PowerLevel);
		MyPlayer.Speed += speed.PowerLevel;
	}
}
