using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{

    public GameObject settingsPanel;

    public void PlayGame()
    {
        SceneManager.LoadScene("SampleScene"); // ชื่อ Scene ของเกมหลัก
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
