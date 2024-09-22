using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMoveWASD : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Vector3 initialPosition;

    void Start()
    {
        // Store the initial position of the sphere
        initialPosition = transform.position;
    }

    void Update()
    {
        // Get input from WASD or arrow keys
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Create a movement vector
        Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical);

        // Move the sphere based on the input and moveSpeed
        transform.Translate(movement * moveSpeed * Time.deltaTime);

        // Check if the Space key is pressed to reset the position
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.position = initialPosition;
        }
    }
}
