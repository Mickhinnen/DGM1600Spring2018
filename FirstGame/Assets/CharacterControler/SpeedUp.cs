using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUp : ScriptableObject
{

	public float Speed = 6;

	void OnTriggerEnter()
	{
		AddSpeed(6);
	}

}
