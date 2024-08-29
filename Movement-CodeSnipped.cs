using System.Collections.Generic;
using UnityEngine; // Removed unnecessary using System.Linq;

public class MomentumScript : MonoBehaviour {
    public float speed = 5.0f;
    public Rigidbody myRigidbody; 									// No need to make it public, it's better to encapsulate it

    void Start() {
       															 // Get the Rigidbody component attached to this game object
        myRigidbody = GetComponent<Rigidbody>();
    }


    void FixedUpdate() {
        // Get the vertical and horizontal input from the user
        float moveVertical = Input.GetAxis("Vertical");
        float moveHorizontal = Input.GetAxis("Horizontal");

        // Create a new Vector3 object to represent the movement
        Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical);

        // Add a force to the Rigidbody in the direction of the movement, scaled by the speed
        myRigidbody.AddForce(movement * speed);
    }
}