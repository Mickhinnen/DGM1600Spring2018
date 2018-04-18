using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunctionsWithReturns : MonoBehaviour {

	public int Health;

	public int AddHealth(int value)
	{
		print("Hello");//returns can have other things in the code at the same time.
		return Health += value;//before just returning 10, now adding each time
	}

	private void OnMouseDown()
	{
		Health = AddHealth(10);
		Players.Add(NewPlayer("BonBon"));
	}



	public List<string> Players;

	public List<string> NewPlayers()
	{
		return new List<string>(); 
	}

	public string NewPlayer(string name)
	{
		return name;
	}
}
