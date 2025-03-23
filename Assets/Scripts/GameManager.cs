using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int[,] targetGrid = new int[3, 3]
    {
        { 1, -1, 1 },
        { -1, 1, -1 },
        { 1, -1, 1 }
    };

    public int[,] currentGrid = new int[3, 3];

    public bool CheckWin()
    {
        for (int x = 0; x < 3; x++)
        {
            for (int y = 0; y < 3; y++)
            {
                if (currentGrid[x, y] != targetGrid[x, y])
                {
                    return false;
                }
            }
        }
        Debug.Log("you win!");
        return true;
    }
}
