using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeSpawner : MonoBehaviour
{
    public GameObject shapePrefab; // keep Prefab of Shape
    public Transform spawnPoint; // spawn location

    void Start()
    {
        SpawnShape(); // create shape when start
    }

    void SpawnShape()
    {
        if (shapePrefab != null && spawnPoint != null)
        {
            Instantiate(shapePrefab, spawnPoint.position, Quaternion.identity);
        }
        else
        {
            Debug.LogError("ShapePrefab or SpawnPoint not setting");
        }
    }
}
