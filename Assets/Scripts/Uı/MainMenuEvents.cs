using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MainMenuEvents : MonoBehaviour
{
    private UIDocument _document;
    
    private Button _startButton;
    private Button _settingsButton;
    private Button _exitButton;
    
    private void Awake()
    {
        _document = GetComponent<UIDocument>();

        _startButton = _document.rootVisualElement.Q("Start") as Button;
        _settingsButton = _document.rootVisualElement.Q("Settings") as Button;
        _exitButton = _document.rootVisualElement.Q("Exit") as Button;
        
        _startButton.RegisterCallback<ClickEvent>(OnPlayGameClick);
        _settingsButton.RegisterCallback<ClickEvent>(OnSettingsClick);
        _exitButton.RegisterCallback<ClickEvent>(OnExitClick);
        
        
        
    }

    private void OnDisable()
    {
        _startButton.UnregisterCallback<ClickEvent>(OnPlayGameClick);
        _settingsButton.UnregisterCallback<ClickEvent>(OnSettingsClick);
        _exitButton.UnregisterCallback<ClickEvent>(OnExitClick);
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

    private void SettingsButton()
    {
        _startButton.visible = false;
        _settingsButton.visible = false;
        _exitButton.visible = false;
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
