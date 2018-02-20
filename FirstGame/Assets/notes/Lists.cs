using System.Collections;
using System.Collections.Generic;//used for lists
using UnityEngine;
using UnityEngine.UI;
public class Lists : MonoBehaviour {

	public TheIncredibles TheIncredibles;
	public Text AddMember;
// can do more with lists than arrays
	 void OnMouseDown()
 
	{
		TheIncredibles.FamilyList.Add("AddMember.Text");
	}

}	
	