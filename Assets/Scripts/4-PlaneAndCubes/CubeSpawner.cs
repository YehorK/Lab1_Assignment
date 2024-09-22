using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public GameObject cubePrefab; // Reference to the cube prefab
    public float spawnHeight = 5f; // Height at which cubes will spawn
    public float spawnInterval = 2f; // Interval between spawns

    void Start()
    {
        StartCoroutine(SpawnCubes());
    }

    IEnumerator SpawnCubes()
    {
        while (true)
        {
            SpawnCube();
            yield return new WaitForSeconds(spawnInterval);
        }
    }

    void SpawnCube()
    {
        // Generate a random position above the plane, fixed Z position
        Vector3 randomPosition = new Vector3(Random.Range(-8f, 8f), spawnHeight, 0f); // Z is fixed to 0
        Instantiate(cubePrefab, randomPosition, Quaternion.identity);
    }
}
