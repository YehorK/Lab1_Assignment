using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MenuSelectionControl : MonoBehaviour
{
    public GameObject RescalingCube;
    public GameObject SphereMovements;
    public GameObject CylinderMouseFollowing;
    public GameObject FallingCubesGame;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DropDownControl(int value) {
        if (value == 0)
        {
            RescalingCube.SetActive(false);
            SphereMovements.SetActive(false);
            CylinderMouseFollowing.SetActive(false);
            FallingCubesGame.SetActive(false);
        }

        if (value == 1)
        {
            RescalingCube.SetActive(true);
            SphereMovements.SetActive(false);
            CylinderMouseFollowing.SetActive(false);
            FallingCubesGame.SetActive(false);
        }

        if (value == 2)
        {
            RescalingCube.SetActive(false);
            SphereMovements.SetActive(true);
            CylinderMouseFollowing.SetActive(false);
            FallingCubesGame.SetActive(false);
        }

        if (value == 3)
        {
            RescalingCube.SetActive(false);
            SphereMovements.SetActive(false);
            CylinderMouseFollowing.SetActive(true);
            FallingCubesGame.SetActive(false);
        }

        if (value == 4)
        {
            RescalingCube.SetActive(false);
            SphereMovements.SetActive(false);
            CylinderMouseFollowing.SetActive(false);
            FallingCubesGame.SetActive(true);
        }
    }
}
