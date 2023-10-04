using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour{
    
    //Assigment of Speed and rotations speed
    private float speed = 10f;
    private float riseSpeed = 25f;
    private float rotationSpeed = 25f;
    
    // Assigment of Inputs
    private float verticalInput;
    private float horizontalInput;
    public float rotationInput;

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical and horizontal input
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
        rotationInput = Input.GetAxis("Rotation");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.right * riseSpeed * verticalInput * Time.deltaTime);
        
        // tilt the plane rotation based  on q/e keys
        transform.Rotate(Vector3.forward * rotationSpeed * rotationInput * Time.deltaTime);

        //tilt the plane rigth or left based on right/left arrow keys
        transform.Rotate(Vector3.up * rotationSpeed * horizontalInput * Time.deltaTime );
        
    }
}
