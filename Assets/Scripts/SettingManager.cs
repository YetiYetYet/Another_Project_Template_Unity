using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingManager : MonoBehaviour
{
    public Toggle fullscreenToggle;
    public Dropdown resolutionDropdown;
    public Resolution[] resolutions;
    public Dropdown qualityDropdown;

    public Slider volumeMaster;
    public Slider volumeMusic;
    public Slider volumeSfx;

    public Dropdown keyBinding;

    public GameSettings gameSettings;

    private void OnEnable()
    {
        gameSettings = new GameSettings();

        resolutions = Screen.resolutions;
        
        InitListener();
    }

    public void InitListener()
    {
        fullscreenToggle.onValueChanged.AddListener(delegate { OnFullScreenToggle(); });
        resolutionDropdown.onValueChanged.AddListener(delegate { OnResolutionChange(); });
        qualityDropdown.onValueChanged.AddListener(delegate { OnQualityChange(); });
        volumeMaster.onValueChanged.AddListener(delegate { OnMasterVolumeChange(); });
        volumeMusic.onValueChanged.AddListener(delegate { OnMusicVolumeChange(); });
        volumeSfx.onValueChanged.AddListener(delegate { OnSfxVolumeChange(); });
        keyBinding.onValueChanged.AddListener(delegate { OnKeyBindingChange(); });
        
    }

    public void OnFullScreenToggle()
    {
        gameSettings.Fullscreen = Screen.fullScreen = fullscreenToggle.isOn;
        Debug.Log("Toggle fullscreen to " + Screen.fullScreen);
    }

    public void OnResolutionChange()
    {
        
    }

    public void OnQualityChange()
    {
        QualitySettings.SetQualityLevel(gameSettings.QualityIndex = qualityDropdown.value);
        Debug.Log("Set Quality Level to " + QualitySettings.GetQualityLevel());
    }

    public void OnMasterVolumeChange()
    {
        
    }
    
    public void OnMusicVolumeChange()
    {
        
    }
    
    public void OnSfxVolumeChange()
    {
        
    }
    
    public void OnKeyBindingChange()
    {
        
    }

    public void SaveSettings()
    {
        
    }

    public void LoadSettings()
    {
        
    }
    
}
