using UnityEngine;

public class PlaneController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 12f; // Speed of the plane movement

    void Update()
    {
        // Move the plane only left and right along the X-axis
        float horizontalInput = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        transform.Translate(horizontalInput, 0, 0); // Y- and Z- axis remain unchanged
    }
}
