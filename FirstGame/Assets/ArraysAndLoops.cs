using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArraysAndLoops : MonoBehaviour {

	
	public int[] Highscores;
	public Player[] Players;
	
	// Use this for initialization
	void Start () {
		foreach (var player in Players)
		{
			print(player.PlayerName);//give us the name of each of the players
			print(player.Score);
			print(player.MPs);
		}
		foreach (var score in Highscores)
		{
			if (score >= 1000)
			{
				print(score);
			}
		}
	}
	
}
