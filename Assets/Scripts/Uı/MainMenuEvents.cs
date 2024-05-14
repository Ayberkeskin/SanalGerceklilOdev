using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MainMenuEvents : MonoBehaviour
{
    private int _sound = 0;
    private int _vibration = 0;
    
    private UIDocument _document;
    
    private Button _startButton;
    private Button _settingsButton;
    private Button _exitButton;
    
    private Button _soundButton;
    private Button _vibrationButton;
    private Button _backButton;
    
    private void Awake()
    {
        _document = GetComponent<UIDocument>();

        _startButton = _document.rootVisualElement.Q("Start") as Button;
        _settingsButton = _document.rootVisualElement.Q("Settings") as Button;
        _exitButton = _document.rootVisualElement.Q("Exit") as Button;
        
        _soundButton = _document.rootVisualElement.Q("Sound") as Button;
        _vibrationButton = _document.rootVisualElement.Q("Vibration") as Button;
        _backButton = _document.rootVisualElement.Q("Back") as Button;
        
        
        _startButton.RegisterCallback<ClickEvent>(OnPlayGameClick);
        _settingsButton.RegisterCallback<ClickEvent>(OnSettingsClick);
        _exitButton.RegisterCallback<ClickEvent>(OnExitClick);
        
        _soundButton.RegisterCallback<ClickEvent>(OnSoundClick);
        _vibrationButton.RegisterCallback<ClickEvent>(OnVibrationClick);
        _backButton.RegisterCallback<ClickEvent>(OnBackClick);
        
        
    }
    
    private void OnDisable()
    {
        _startButton.UnregisterCallback<ClickEvent>(OnPlayGameClick);
        _settingsButton.UnregisterCallback<ClickEvent>(OnSettingsClick);
        _exitButton.UnregisterCallback<ClickEvent>(OnExitClick);
        
        _soundButton.UnregisterCallback<ClickEvent>(OnSoundClick);
        _vibrationButton.UnregisterCallback<ClickEvent>(OnVibrationClick);
        _backButton.UnregisterCallback<ClickEvent>(OnBackClick);
    }

    private void OnPlayGameClick(ClickEvent evt)
    {
        Debug.Log("Oyun ekranı");
       
    }

    private void OnSettingsClick(ClickEvent evt)
    {
        Debug.Log("Settings");
        SettingsButton();
    }
    private void OnExitClick(ClickEvent evt)
    {
        Debug.Log("Exit");
        ExitButton();
    }
    
    private void OnSoundClick(ClickEvent evt)
    {
        Debug.Log("sound");
        if (_sound==0)
        {
            _soundButton.text = "Sound:Off";
            _sound = 1;
        }
        else if (_sound==1)
        {
            _soundButton.text = "Sound:On";
            _sound = 0;
        }
        
    }
    private void OnVibrationClick(ClickEvent evt)
    {
        Debug.Log("vibration");
        if (_vibration==0)
        {
            _vibrationButton.text = "Vibration:Off";
            _vibration = 1;
        }
        else if (_vibration==1)
        {
            _vibrationButton.text = "Vibration:On";
            _vibration = 0;
        }
        
    }
    private void OnBackClick(ClickEvent evt)
    {
        
        _soundButton.style.display = DisplayStyle.None;
        _vibrationButton.style.display = DisplayStyle.None;
        _backButton.style.display = DisplayStyle.None;
        Debug.Log("back");
        
        _startButton.style.display = DisplayStyle.Flex;
        _settingsButton.style.display = DisplayStyle.Flex;
        _exitButton.style.display = DisplayStyle.Flex;
    }

    private void SettingsButton()
    {
        _startButton.style.display = DisplayStyle.None;
        _settingsButton.style.display = DisplayStyle.None;
        _exitButton.style.display = DisplayStyle.None;
        
        _soundButton.style.display = DisplayStyle.Flex;
        _vibrationButton.style.display = DisplayStyle.Flex;
        _backButton.style.display = DisplayStyle.Flex;



    }
    
    
    private void ExitButton()
    {
#if UNITY_EDITOR
        // Editör içinde çalışırken oyunu durdurur
        UnityEditor.EditorApplication.isPlaying = false;
#else
            // Build edilen oyunu kapatır
            Application.Quit();
#endif
    }
}
