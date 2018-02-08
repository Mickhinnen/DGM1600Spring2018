using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu]
public class PowerUp : ScriptableObject {

	public int PowerLevel = 100;
	public Player CurrentPlayer;
	public void RunPowerUp()
	{
		CurrentPlayer.Score += PowerLevel;
		//file.reference in file
		//Adds value
		//Debug.Log(PowerLevel);//log means log to consol, can't print not mono. debug is a class
	}

}
