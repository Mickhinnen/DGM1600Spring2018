using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notes : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
/*Int- integer: whole numbers. Floats : 1.00001 etc, foats take more data, bigger numbers.
Strings-a string of characters, a rule has to start and end "" (Print is a function that 
prints strings,) string is a data type. Spaces are considered characters. These are variables, types 
of data, String, Int, and Float are a class*/
 
 /* using UnityEngine.UI.. is a folder with classes in it, another box.
 UI is text box on screen of game. */
 
 /* Variable in english is a thing that can change. I believe it is the same in c#, however 
 we as the scripters are the ones instigating that change in the variables. Today we focused on
 three of them. Int, Float, and String. Int, short for integer is, for math geniouses, a 
 whole number, this stays true in C#. This can be seen in codeing with things such as Foodcounter
 which we were able to change or if left blank is at 0. Float is also a number type data but in
 other numbers in decimal, numbers such as 1.00045, etc. While this can help it takes up more space
 as it uses more characters. I can see this being used in counters like racing games for a 
 speedomoter, or a points system. String is a word variable. Pieces of lingual data strung together.
 We used this with imputing a name on our objects and having it reference, print text for actions
 like on start or onmousedown. And thats about the extent of my understanding.
 
 If statements
 if ("hello" == "hello"){ true runs code} if ("hello" != "hi") true run code
 if ("hello" == "hi") false. Bool true or false statements. == means to compare
 else clause
 if(true statement){ run code} else {run code}* else is a place within if statments 
 + add - sub * times / divide but = assign Value == check equality != check unequality
 >=   >   <=  < 
 
 Scriptable object
 

 Array
 all the same type with slats and two posts. Strinf[]players Jen0, Jim1, Jan2. Jerry3
 (these are the slats, 6 things 0-5) [] makes it an array. type[] nameOfArray = new type [number of elements];
 note that by type meaning int, string etc and second type is same as first type it int[] Health = new int[5];
 
 
 loops
 loops tell us everything about an array 
 foreach (var player in Players)
		{
			print(player); a loop printing all the names of players in the array}
	for loops
	for loop is declaration, if statement, do the equation/ do work	
	for (int i = 0;//declears it a zero
	 	i < UPPER;//if (i<var)
		i++)//+1
	for (int i = 0; i < numEnemies; i++) practise but not recwired to be and i, i is index

Lists
lists are like arrays, lists use collections.generic
add and change in game and in code, in game temp. PlayerNameList.add("Dash")
PlayerNameList.remove("Hellan") Again temporay file change. For permanent use scritableobject
ScriptableObject + list = player changing content

Switch statements
if is good for true and false, yes and no. Switch is better for multiple options
statement: switch(); however inside is different. switch (string); case "Password": //do work
case all sorts of stuff as long as same type. can be anykind of data. case strings, enum?, scriptable object.

Functions with Returns
//Functions with returns are not void, they are a data type
	void start ()
	{does work, returns nothing.
		 MyInt = AddHealth();
	}

	public int MyInt = 100;// data type

	public int AddHealth()
	{
		return 100;
	}//same as public int MyInt = 100;


input
if(Input.GetKeyDown(KeyCode.Space))//KeyCode.anykey such as a d s w
		{
			Run();
 */