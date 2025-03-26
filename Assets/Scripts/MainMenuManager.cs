using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{

    public GameObject settingsPanel;
    public GameObject TutorialPanel;

    public void PlayGame()
    {
        SceneManager.LoadScene("Level1"); // ชื่อ Scene ของเกมหลัก
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

    public void QuitGame()
    {
        Application.Quit();

        UnityEditor.EditorApplication.isPlaying = false; // สำหรับออกจาก Play Mode ใน Unity Editor

    }
}
