using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance; // 

    public int[,] targetGrid = new int[3, 3]  // 
    {
        { 1, -1, 1 },
        { -1, 1, -1 },
        { 1, -1, 1 }
    };

    public int[,] currentGrid = new int[3, 3]; // 

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            Debug.Log("GameManager Instance");
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void CheckWin()
    {
        for (int x = 0; x < 3; x++)
        {
            for (int y = 0; y < 3; y++)
            {
                if (currentGrid[x, y] != targetGrid[x, y])
                {
                    return; // 
                }
            }
        }

        Debug.Log("win");
    }
}
