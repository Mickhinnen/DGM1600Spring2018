using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assighnments : MonoBehaviour {

/* If Statments (in class)
If statements are use if there are two opptions and can be used if its an all or nothing 
type, like if its true than something happens but if it doesnt match up than nothing happens.
Such as having a name in if, if (Name == Cat); {print("meow"); } Having it set like this makes it 
so that if your object is named cat than depending on the script meow will be printed on start or 
when called such as onmousedown. However nothing else will happen should the script be aplied to 
an object with a different name. If statements have to match up, that doesn't mean the statement 
has to be positive or equal. For example instead of comparing for a match up with ==, you can 
instead instruct the program to look for a negative or unmatching statement. if ( Name != cat) 
{ print("bark")} with this line of script should the object be anything but cat then bark will be
printed in the situation. Now the nice thing about if statment is that its not just limited to 
just true or false, they can also be numerical. When using classes such as Foodcounter that use int
you can use <, >, >=, or <= in the statement. if ( Foodcounter > 0): { print("my cat has food"); } 
this will check the food counter and if the number is higher than 0 it will follow the code. 
However nothing will happen if the counter is less than zero unless you put in another if statment 
for otherwise like if (Foodcounter <= 0); {print("my cat doesn't have food"); }. If statment can 
also trigger other things such as unlocking a door. Say you want to have locked door that needs a 
key in your script first you add a bool. public bool key; unless you state otherwise this will be 
automaticaly false. then you can script if ( key == false); { print("the door is locked"); }
if (key == true); { print("the door is open"); } This can be toggled in the game to open and close
a door, with more coding this can turn off and on a light switch, decided what an object says if 
the situation matches and so on. Either way I like If statements. */

/* Else Clause Homework
 The else clause works with if statements really turning it to a two option code. Going back to 
 the example of using a name we can change if (Name == cat); { print("meow"); } so that either way
 there is an action taking by scripting it as if( "Name == cat"); { print("meow"); } else { 
 print("bark"); } making it so that any object but cat will bark when called. With the foodcounter
 again it expanse the code, if(Foodcounter > 0); { print("my cat has food"); } else { print("My cat
 doesnt have food"); } This can end a game if useing health, after adding public int Health = 100,
 write if(Health > 0); { print("Game Start"); } else { print("Game Over") } or it can be used for 
 a passwor by adding public string Password = "Gotta Catch Them All" or whatever you want as a password
 then add if(Password == "Gotta Catch Them All") { print("Open"); } else { print("No"); } Thoughwhats 
 neat to is that all this can be shortend into if(key ? "Door unlocked" : "Door is locked"); or such
 however as fun as if or else is its really only best to use it for one or the other situations as
 putting in multiple options this way can get really long.    */