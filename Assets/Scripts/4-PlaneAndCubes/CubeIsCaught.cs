using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeIsCaught : MonoBehaviour
{
    void OnCollisionEnter(Collision collision) // Check for the coliders collision
    {
        // Check if the cube collided with the plane
        if (collision.gameObject.CompareTag("Plane")) // the same Tag "Plane" must be also assigned to the Plane gameobject
        {
            StartCoroutine(DestroyAfterDelay(0.5f)); // Start the coroutine - the function used to create a delay in execution
        }
    }

    private IEnumerator DestroyAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay); // Wait for the specified delay
        Destroy(gameObject); // Destroy the cube
    }
}
