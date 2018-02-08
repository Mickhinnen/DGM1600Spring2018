using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathOperatorsClass : MonoBehaviour {

	public int Score = 0;
	public int PowerUp = 10;
	//public int C = 10;

	void OnTriggerEnter()
	{
		Score += PowerUp;
	}


	
		void Start () 
		{
			/*if (A + B == C)
			{
				print(C);
			}
			if (C - A == B)
			{
				print(B);
			}
			if (A * B == C)
			{
				print(C);
			}
			if (A / B == C) //will become float
			{
				print(C);
			}
			if (A <= 0)
			{
				A++;//increases by 1
			}
			if (A >= 10)
			{
				A--; //-- is a short cut for minus 1, incrumentor.
			}
			C = A + B;// 20
			C += A + B;// 40,pemdas
			C = A - B;//40, 0*/

		
		}
	
}