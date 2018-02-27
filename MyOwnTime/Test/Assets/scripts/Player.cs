using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    private Rigidbody rb;
    private bool ismovingright = false;

    [SerializeField]
    float speed = 4f;
    void start () {
        rb = this.GetComponent<Rigidbody> ();
    }

    void Update () {
        if (Input.GetMouseButtonDown (0)) {
            ChangeBoolean ();
            ChangeDirection ();
        }
    }

    private void ChangeBoolean () {
        ismovingright = !ismovingright;
    }
    private void ChangeDirection () {
        if (ismovingright) {
           rb.velocity = new Vector3(speed, 0f, 0f);
        } else {
             rb.velocity = new Vector3(0f, 0f, speed);
        }
    } /* code for movement
    var x = Imput.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
    var z = Imput.GetAzis("Vertical") * Time.deltaTime * 3.0f
    
    transform.Rotate(0, x, );
    transform.Translate(0, 0, z); */
}