using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "BoolInput")]
public class BoolInput : InputBase {

	public string InputName = "Jump";
	public float FloatValue = 1;
	private bool additionalJump = false;

	public override float SetFloat()
	{
		if (Input.GetButton(InputName))
		{
			return FloatValue;
		}
		else
		{
			return 0;
		}
	}
	
}
