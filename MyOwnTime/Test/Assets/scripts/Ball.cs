using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
public float speed = 4f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		var x = Imput.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
    var z = Imput.GetAzis("Vertical") * Time.deltaTime * 3.0f
    
    transform.Rotate(0, x, 0);
    transform.Translate(0, 0, z);
	}
}
