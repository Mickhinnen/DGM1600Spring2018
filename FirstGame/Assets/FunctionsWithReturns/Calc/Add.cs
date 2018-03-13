using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Add : Calculation 
{

	public override float Calculate(string a, string b)
	{
		 aNum = float.Parse(a);
		 bNum = float.Parse(b); //parse means to convert
		return aNum + bNum;
	}	
}
