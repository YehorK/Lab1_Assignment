using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMoving : MonoBehaviour
{
    public GameObject spherePrefab;
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float sphereLifetime = 2.5f;
    private float distanceThreshold = 1f; // Distance between spheres

    private Vector3 lastPosition; // To keep track of the last known position

    private void Start()
    {
        lastPosition = transform.position; // Initialize the last position
    }
    private void Update()
    {
        MoveCube();
    }

    private void MoveCube()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        transform.Translate(movement * moveSpeed * Time.deltaTime);

        if (movement != Vector3.zero) // Create the trail if the cube is moving
        {
            CreateTrailSphere();
        }
    }

    private void CreateTrailSphere()
    {
        // Check the distance traveled since the last sphere
        if (Vector3.Distance(transform.position, lastPosition) >= distanceThreshold)
        {
            GameObject sphere = Instantiate(spherePrefab, transform.position, Quaternion.identity);
            Destroy(sphere, sphereLifetime);
            sphere.GetComponent<Renderer>().material.color = Random.ColorHSV(); // Use the API for random color selection for newly generated spheres

            // Update the last position
            lastPosition = transform.position;
        }
    }
}
