using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public GameObject settingsPanel;
    public GameObject TutorialPanel;
    public GameObject LevelPanel;
    public GameObject creditsPanel;

    public RectTransform creditsText;
    public float scrollSpeed = 50f;
    private bool isScrolling = false;

    public void OpenLevelPanel()
    {
        LevelPanel.SetActive(true); // เปิด Panel
    }

    public void CloseLevelPanel()
    {
       LevelPanel.SetActive(false); // ปิด Panel
    }

    public void Tutorial()
    {
        SceneManager.LoadScene("Tutorial");
    }

    public void Main()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void OpenTutorial()
    {
        TutorialPanel.SetActive(true); // เปิด Panel
    }

    public void CloseTutorial()
    {
        TutorialPanel.SetActive(false); // ปิด Panel
    }

    public void OpenSettings()
    {
        settingsPanel.SetActive(true); // เปิด Panel
    }

    public void CloseSettings()
    {
        settingsPanel.SetActive(false); // ปิด Panel
    }

    public void OpenCredits()
    {
        creditsPanel.SetActive(true);
        isScrolling = true;
        creditsText.anchoredPosition = new Vector2(creditsText.anchoredPosition.x, -500f);
    }

    public void CloseCredits()
    {
        creditsPanel.SetActive(false);
        isScrolling = false;
    }

    public void QuitGame()
    {
        Application.Quit();

        //UnityEditor.EditorApplication.isPlaying = false; 

    }
    void Update()
    {
        if (isScrolling)
        {
            creditsText.anchoredPosition += new Vector2(0, scrollSpeed * Time.deltaTime);
        }
    }
}
