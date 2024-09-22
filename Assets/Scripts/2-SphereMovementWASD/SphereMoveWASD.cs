using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMoveWASD : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    private Vector3 initialPosition;

    void Start()
    {
        // Store the initial position of the sphere
        initialPosition = transform.position;
    }
    
    void Update()
    {
        // Get input from WASD and/or arrow keys
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Create a movement vector
        Vector3 movement = new Vector3(moveHorizontal, moveVertical, 0f); // moveVertical and 0f can be interchanged to make the sphere move in the XY or XZ planes

        // Move the sphere based on the input and moveSpeed
        transform.Translate(movement * moveSpeed * Time.deltaTime);

        // Use the Space key to reset the position
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.position = initialPosition;
        }
    }
}
