using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpReturn : MonoBehaviour {

	public Player CurrentPlayer;

	public int PowerLevel = 10;
	public int PowerLevelIncrease = 2;

	public int IncreasePowerLevel()
	{
		PowerLevel += PowerLevelIncrease;
		PowerLevel *= PowerLevelIncrease;
		return PowerLevel;
		//this can be more than one line
	}


	private void OnMouseDown()
	{
		CurrentPlayer.Health = IncreasePowerLevel(); 
	}


}
