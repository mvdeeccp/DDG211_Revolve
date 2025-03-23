using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    public int gridSize = 3;
    public GameObject gridCellPrefab;

    void Start()
    {
        GenerateGrid();
    }

    void GenerateGrid()
    {
        for (int x = 0; x < gridSize; x++)
        {
            for (int y = 0; y < gridSize; y++)
            {
                GameObject cell = Instantiate(gridCellPrefab, new Vector3(x, y, 0), Quaternion.identity);
                cell.transform.parent = transform;
            }
        }
    }
}
