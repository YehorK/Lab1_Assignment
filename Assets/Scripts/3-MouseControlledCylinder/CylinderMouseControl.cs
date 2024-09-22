using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderMouseControl : MonoBehaviour
{
    private Transform cylinder; // Reference to the cylinder

    void Start()
    {
        // Get the cylinder (assumed to be the child of the Empty GameObject)
        cylinder = transform.Find("Cylinder"); // 
    }

    void Update()
    {
        // Check if left mouse button is clicked and held down
        if (Input.GetMouseButton(0))
        {
            MoveCylinderToMouse();
        }
    }

    void MoveCylinderToMouse()
    {
        // Raycast from the mouse position to the world
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit hit)) // Checking the projected ray and any possible collisions
        {
            // Update the cylinder's position  to the mouse position on the ground plane
            cylinder.position = new Vector3(hit.point.x, hit.point.y, cylinder.position.z); // Keep z position unchanged - so we move in XY plane
        }
    }
}