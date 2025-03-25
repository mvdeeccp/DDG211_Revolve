using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class VolumeControl : MonoBehaviour
{
    public TextMeshProUGUI volumeText; // ตัวเลขแสดงค่าเสียง
    public float volume = 1.0f; // เริ่มต้นที่ 100% (1.0)
    public float step = 0.1f; // เพิ่ม/ลดทีละ 10%

    void Start()
    {
        UpdateVolumeText();
    }

    public void IncreaseVolume()
    {
        volume = Mathf.Clamp(volume + step, 0f, 1f); // เพิ่มเสียง แต่ไม่เกิน 100%
        ApplyVolume();
    }

    public void DecreaseVolume()
    {
        volume = Mathf.Clamp(volume - step, 0f, 1f); // ลดเสียง แต่ไม่ต่ำกว่า 0%
        ApplyVolume();
    }

    void ApplyVolume()
    {
        AudioListener.volume = volume; // ตั้งค่าระดับเสียงของเกม
        PlayerPrefs.SetFloat("GameVolume", volume); // บันทึกค่าลงเครื่อง
        UpdateVolumeText();
    }

    void UpdateVolumeText()
    {
        volumeText.text = (volume * 100).ToString("0") + "%"; // แสดงค่าเสียงเป็น %
    }
}
