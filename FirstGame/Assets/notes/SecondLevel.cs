using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Class is an object classification
//You must have and closed per object
//void is a function that is empty or null
public class SecondLevel : MonoBehaviour {

    // Use this for initialization
    public bool key = false; //explisite decloration, otherwise implied false
    public int Health = 100;
    public string Password = "OU812";

    void Start () {
        if (Health > 0) {
            print ("can play");
        } else {
            print ("game over");
        }

        if (Password == "OU812") {
            print ("access granted");
        } else {
            print ("deniyed");
        }
    }
    void OnMouseDown () {
        if (key == true) //if(key) is same thing
        {
            print ("open door");
        }
        if (key == false) {
            print ("Door is locked");
        } //box collider,set to trigger
    } //shorter way to write it, if (key ? "open door" : "door is locked");
}