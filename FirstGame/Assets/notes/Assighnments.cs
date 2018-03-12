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
 putting in multiple options this way can get really long 
 
 Logical Opperators
 logical opperators use symbols like && (and), ||(or), <(less than), > (greater than), and ==(equal to)
 to check for truth in a string. For example we've used if statments such as if ( Password == "OU812")
 { print("door opens"); } in use of keys and passwords to check to see if it matches up. We've used
  >, <, and = to get different reactions like "too much", "not enough", "equal" *door opens*, these 
  are basically math operations but instead of the computer doing math functions it checks for truth
  and runs a code if its found true, sometimes more than one if multiple opperations are true.

 Math Opperations
 the class of math operators is as stated for math in a code. simple addition +, subtraction -, 
 multiplication *, and even division / though that one will turn into a float. with these you can
 make a counter that adds on like powerups, health, bullets, sheild repair, heck even a love counter.
 It all depends on the game you want to make. Its done with a formula of C += A + B. A being player
 health, ammo, etc. B being the powerup and C being the combined amount of powerup and player level.
 This is a click points game in a nutshell.

 Arrays 
 arrays are like files with groups of the same things in it such as playersnames, highscores, points, 
 health, etc. And they work like this Sting[] Players while being indicated with the brackets [], basically
  the posts or bookends of the file or groups. This can be used with int as well ex int[] Highscore. This 
  would collect the data of the highscores from the players. The benefit to having arrays is not having
  to go through and write a code for each individual player in the game stating things like name, power,
  and health. public player[] Players; public int[] health; public int[] Mps; public powerups[] Powerups;
  public playernames[] Playernames

 Foreach Loops
 loops are used to show what is in an array, we used a loop to show the PLayernames, Highscore, and MPS
 in the array we created in class this was done with the code foreach (var player in PLayers) { print
 (player.PlayerName); } this was a single instance loop that desplayed all the names of the players from 
 the player code through referencing said code. using the .PlayerName part.

 Lists
 Lists are like arrays in that they group together same types of data. the difference is first that lists
 use <> instead of [], and the more helpfull one is that with a list other people other than the coder can 
 change information in the game, people such as the player. The list is made as such, first you must have 
 a  system.Collections.Generic; in the beging of the code to use lists. then List<Name> name = new List<Name>();
 now you can do a lot more withs lists than arrays such as adding to or removing from the lists. counting etc
 In class we made a list of the incredibles family. public List<string> FamilyList; and made a scriptableObject
 with that we can add to that list using TheIncredibles.FamilyList.Add("famiilymember") ofcourse ours was 
 TheIncredibles.FamilyList.Add("Dash"); Then we can also remove people to like PlayerNames.Remove("player5"); thing is
 these types of changes to the list are only temperary. With the help of a scriptableobject we can make these changes
 permenant. Using system UnityEngine.UI we can make a text input box that we can type into during game play that
 will permenantly add players. This can have restrictions placed on it to prevent repeats, limit amount of players 
 and retrict player names.
 
 Switches
 switches are an alternative to if statements and are better for when there is more than two ansers. Where if statements
 are used for true or false and can of more than two with the if else clause, they run through every option instead of 
 stoping when the true statement is found. Switch statements alow for more than one option but also has an added bit of 
 code for kicing the program out of the string once the correct answer is found. 
 switch (intelegence)                   switch (MyPowerUp.Name)
 {                                       {
     case 5:                              case "Ammo"
        print ("Good day my lady");         print("+ " + int + "ammo");
        break;                              break;
     case 4:                              case "Health"
        print ("Hello");                    print("+" + int + "Health");
        break;                              break;
     case 3:                              case "sheild"
        print("Hi");                        print("+" + int + "sheild bonus");
        break;                              break;
     case 2:                              case "Reload time"
        print("What's up");                 print("reload time decrease");
        break;                              break;
     case 1:                              case "Recovery"
        print("YOLO");                      print("Recovery time decreased");
        break;                             break;
    default:                             
        print("....");                     
        break
 }
 
 For loops

 for loops are nearly the same as foreach loops in that they also group data and variables. Most notable that for loops are 
 better for counting. For loops can begin with a decloration, this is optional but alows us to set a variable for the loop.
 For example we couild start with 10 or 0 depending on if we wish to increase or decrease the variable. Next is an if 
 statement that if true will run the loop, followed by a decrement or increase. these are all seperated by ; instead of ,
 after setting an integer like int numEnemies = 3; you can have a for loops such as for (int i = 0; i < numEnemies; i++)
 { Debug.Log ("Creating enemy number : " + i); }
 or int numDirtyDishes = 4 for (int i = 0; i < numDirtyDishes; i--) { Debug.Log ("Cleaning Dishes"); }
int numApples = 5 for (i = numApples) { Debug,Log("I have 5 apples"); } int numDragonEggs = 0 for( i = 10; i > numDragonEggs;
i++) { Debug.Log("I found a Dragon Egg"); }

Void Function
void means return nothing, its used in the begining of calling a function.
Void start, void onmousedown, void update, void OnTriggerEnter, 


scope and access modifier
scope is basically another term for our box. the braces we use marks a scope with information/data in it such as
monobehavior{               as for access modifiers these refer to public or private class of a script
                        these decide how accessable data in the script is. Having public in the script makes relevant                 
    void start()       scopes accessable to other scripts and changable during game testing. Where as private can only be
    {                   accessed within the script.
        print etc
    }
    void onmousedown
    {
        print
    }
    if statement
    { true}
        than
    {run code}
}



 */
}