using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuzzleChecker : MonoBehaviour
{
    public GameObject[] blocks;
    public Transform[] correctPositions; 
    public Button checkButton; 


    void Start()
    {
        checkButton.onClick.AddListener(CheckPuzzleCompleted); 
    }

    void CheckPuzzleCompleted()
    {
        bool isCorrect = true;

        for (int i = 0; i < blocks.Length; i++)
        {
            
            Vector2 blockPos = blocks[i].transform.position;
            Vector2 correctPos = correctPositions[i].position;

            
            float blockRotation = blocks[i].transform.eulerAngles.z;
            float correctRotation = correctPositions[i].eulerAngles.z;

            
            float distance = Vector2.Distance(blockPos, correctPos);
            if (distance > 0.1f)
            {
                isCorrect = false;
                Debug.Log($"Block {i + 1} false Location! Distance = {distance}");
                break;
            }

            
            if (Mathf.Abs(blockRotation - correctRotation) % 360 != 0)
            {
                isCorrect = false;
                Debug.Log($"Block {i + 1} false Rotation = {blockRotation}, should be {correctRotation}");
                break;
            }
        }

        
        if (isCorrect)
        {
            Debug.Log("pass!");
            checkButton.image.color = Color.green;
            FindObjectOfType<LevelManager>().LoadNextLevel();
        }
        else
        {
            Debug.Log("try again!");
            checkButton.image.color = Color.red;
        }
    }

}
