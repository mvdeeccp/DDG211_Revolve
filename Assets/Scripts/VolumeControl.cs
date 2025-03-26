using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class VolumeControl : MonoBehaviour
{
    public TextMeshProUGUI volumeText;
    public TextMeshProUGUI buttonVolumeText;

    public float volume = 1.0f;
    public float buttonVolume = 1.0f;
    public float step = 0.1f;

    // ใช้ AudioSource แยกแต่ละเสียง
    public AudioSource clickAudioSource;
    public AudioSource confirmAudioSource;
    public AudioSource cancelAudioSource;

    void Start()
    {
        volume = PlayerPrefs.GetFloat("GameVolume", 1.0f);
        buttonVolume = PlayerPrefs.GetFloat("ButtonVolume", 1.0f);
        ApplyVolume();
    }

    public void IncreaseVolume()
    {
        volume = Mathf.Clamp(volume + step, 0f, 1f);
        ApplyVolume();
    }

    public void DecreaseVolume()
    {
        volume = Mathf.Clamp(volume - step, 0f, 1f);
        ApplyVolume();
    }

    public void IncreaseButtonVolume()
    {
        buttonVolume = Mathf.Clamp(buttonVolume + step, 0f, 1f);
        ApplyButtonVolume();
    }

    public void DecreaseButtonVolume()
    {
        buttonVolume = Mathf.Clamp(buttonVolume - step, 0f, 1f);
        ApplyButtonVolume();
    }

    void ApplyVolume()
    {
        AudioListener.volume = volume;
        PlayerPrefs.SetFloat("GameVolume", volume);
        UpdateVolumeText();
    }

    void ApplyButtonVolume()
    {
        // ตั้งค่าเสียงของทุก AudioSource ที่ใช้เล่นเสียงปุ่ม
        if (clickAudioSource) clickAudioSource.volume = buttonVolume;
        if (confirmAudioSource) confirmAudioSource.volume = buttonVolume;
        if (cancelAudioSource) cancelAudioSource.volume = buttonVolume;

        PlayerPrefs.SetFloat("ButtonVolume", buttonVolume);
        UpdateVolumeText();
    }

    void UpdateVolumeText()
    {
        volumeText.text = (volume * 100).ToString("0") + "%";
        buttonVolumeText.text = (buttonVolume * 100).ToString("0") + "%";
    }

    public void PlayClickSound()
    {
        if (clickAudioSource) clickAudioSource.Play();
    }

    public void PlayConfirmSound()
    {
        if (confirmAudioSource) confirmAudioSource.Play();
    }

    public void PlayCancelSound()
    {
        if (cancelAudioSource) cancelAudioSource.Play();
    }
}
