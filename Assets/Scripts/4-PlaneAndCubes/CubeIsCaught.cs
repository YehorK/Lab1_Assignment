using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeIsCaught : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        // Check if the cube collided with the plane
        if (collision.gameObject.CompareTag("Plane"))
        {
            StartCoroutine(DestroyAfterDelay(0.5f)); // Start the coroutine with a delay
        }
    }

    private IEnumerator DestroyAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay); // Wait for the specified delay
        Destroy(gameObject); // Destroy the cube
    }
}
