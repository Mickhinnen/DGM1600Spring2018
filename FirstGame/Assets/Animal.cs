using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Animal : MonoBehaviour /*class is a thing of code meaning 
Im gonna do something. Class can not function on its own. {} is a box */
 {
 public string Name;
 public int Foodcount;
 public Text myUIText;
	// Use this for initialization
	// This declares what start will do
	void Start () //void means I'm gonna do something, () means its a function.
	{
		print("my animal is eating.");
		print("Now my animal is sleeping");
		//print does not exsist with a capital P, it must be lower case.
		//idicates notes, and indicates for the computer to ignore it.
		// this () indicates a function, must have "" for a string of txt.
		// this {} is an object, a box.
		// print is a function call.
		// this ; is a period, ends a line of txt.
		print("I love mt cat.");
	}
	void OnMouseDown()
	{
		myUIText.text = "I have a " + Name + "It has this amount of food: " + Foodcount;
	}

	
	// Update is called once per frame
	/*  A line of code is either data or work
	 : Print (is work)("i Love my cat"(is data))
	 Start is a decloration (declaired by keyword void),
	 identifier (something we can call on. ie animal, dog, etc)
	 */
	
}
/*Comments for in class assignment 1-23-18
 I'm still a little lost but my understaning is that the syntax of this program is like a cross
 between a nesting doll and a box. The first box is just what you want and its either public see
 through or private and made of cardboard indicated by open and close {}. It starts with a 
 decloration like viod followed by a work such as start or onmousedown, which is followed by 
 an identifier such as animal, building etc. Then lastly followed by a () if its a function 
 which to my understanding it usually is. In () is data for example "I have a cat" 
  is just text that can show up on the screen because its in quotation. And really thats about it
  i need to read some more*/