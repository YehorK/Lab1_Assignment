using UnityEngine;

public class CubeController : MonoBehaviour
{
    //Making scale and color change speed to be private yet accessible in Unity editor
    [SerializeField] private float scaleSpeed = 1f; //Speed for growing/Shrinking of the cube
    [SerializeField] private float scaleIncrease = 2f; //How much from the original size the cube will change - both grow and shrink
    [SerializeField] private float colorSpeed = 1f; //Speed for the colors transition

    private bool isGrowing = true; // A boolean for determining whether the cube is shrinking or growing at the moment
    private Vector3 initialScale; // Reference to the initial scale of the object
    private Renderer cubeRenderer; // Accessing cube's material and changing its color
    private Transform cubeTransform; // Needed for manipulation of the position, rotation,and scale of the object

    // Private variables for the start and end colors, can be changed in the Unity Inspector
    [SerializeField] private Color startColor;   // Default to red
    [SerializeField] private Color endColor;    // Default to blue

    void Start()     // Start function to initialize
    {
        // Find the cube child object
        cubeTransform = transform.Find("Cube"); // Assuming the cube is named "Cube" - to be changed if required
        if (cubeTransform != null) // Checking that the Cube exists 
        {
            // Save the initial scale of the cube
            initialScale = cubeTransform.localScale;

            // Get the cube's Renderer component
            cubeRenderer = cubeTransform.GetComponent<Renderer>(); // Required for changing the appearance of the object
        }
        else
        {
            // Output the error to the console in case the cube is not found
            Debug.LogError("Cube not found in child objects.");
        }
    }

    void Update() //Elements to be continiously updated
    {
        if (cubeTransform == null) return; // Handling a possibility if Cube is not found

        // Handle scaling
        float scaleChange = scaleSpeed * Time.deltaTime; // Standardizing the speed in time
        if (isGrowing) // For cube to grow
        {
            cubeTransform.localScale += new Vector3(scaleChange, scaleChange, scaleChange);
            if (cubeTransform.localScale.x > initialScale.x * scaleIncrease)
            {
                isGrowing = false;
            }
        }
        else // For cube to shrink
        {
            cubeTransform.localScale -= new Vector3(scaleChange, scaleChange, scaleChange);
            if (cubeTransform.localScale.x < initialScale.x / scaleIncrease)
            {
                isGrowing = true;
            }
        }

        // Handle smooth color change
        float colorLerp = Mathf.PingPong(Time.time * colorSpeed, 1); // API for increments 
        cubeRenderer.material.color = Color.Lerp(startColor, endColor, colorLerp); // Interpolation
    }
}
