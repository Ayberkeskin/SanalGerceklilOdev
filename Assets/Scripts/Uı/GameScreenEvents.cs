
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
public class GameScreenEvents : MonoBehaviour
{
    
    private UIDocument _document;
    
    private Button _marketButton;
    private Button _settingsButton;
    private Button _playButton;
    
    
    private Button _soundButton;
    private Button _vibrationButton;
    private Button _backButton;
    private Button _mainMenuButton;
    
    private Button _menuButton;
    private Button _menuBackButton;
    
    
    
    
    private int _sound = 0;
    private int _vibration = 0;
    
    private void Awake()
    {
        _document = GetComponent<UIDocument>();

        _marketButton = _document.rootVisualElement.Q("Market") as Button;
        _settingsButton = _document.rootVisualElement.Q("Ayarlar") as Button;
        _playButton = _document.rootVisualElement.Q("Oyun") as Button;
        
        _backButton = _document.rootVisualElement.Q("Back") as Button;
        _mainMenuButton = _document.rootVisualElement.Q("Anamenu") as Button;
        _soundButton = _document.rootVisualElement.Q("Sound") as Button;
        _vibrationButton = _document.rootVisualElement.Q("Vibration") as Button;
        
        _menuButton = _document.rootVisualElement.Q("MainMarket") as Button;
        _menuBackButton = _document.rootVisualElement.Q("MarketKapat") as Button;

        _marketButton.RegisterCallback<ClickEvent>(OnMarketClick);
        _settingsButton.RegisterCallback<ClickEvent>(OnSettingsClick);
        _playButton.RegisterCallback<ClickEvent>(OnPlayGameClick);
        
        _backButton.RegisterCallback<ClickEvent>(OnBackClick);
        _mainMenuButton.RegisterCallback<ClickEvent>(OnMainMenuClick);
        _soundButton.RegisterCallback<ClickEvent>(OnSoundClick);
        _vibrationButton.RegisterCallback<ClickEvent>(OnVibrationClick);
        
        
        _menuButton.RegisterCallback<ClickEvent>(OnMenuClick);
        _menuBackButton.RegisterCallback<ClickEvent>(OnMarketBackClick);
        
        
    
    }
    
    private void OnDisable()
    {
        _marketButton.UnregisterCallback<ClickEvent>(OnMarketClick);
        _settingsButton.UnregisterCallback<ClickEvent>(OnSettingsClick);
        _playButton.UnregisterCallback<ClickEvent>(OnPlayGameClick);
        
        _backButton.UnregisterCallback<ClickEvent>(OnBackClick);
        _mainMenuButton.UnregisterCallback<ClickEvent>(OnMainMenuClick);
        _soundButton.UnregisterCallback<ClickEvent>(OnSoundClick);
        _vibrationButton.UnregisterCallback<ClickEvent>(OnVibrationClick);
        
        _menuButton.UnregisterCallback<ClickEvent>(OnMenuClick);
        _menuBackButton.UnregisterCallback<ClickEvent>(OnMarketBackClick);

    }
    private void OnPlayGameClick(ClickEvent evt)
    {
        Debug.Log("game");
        SceneManager.LoadScene(2);
    }
    private void OnMenuClick(ClickEvent evt)
    {
        Debug.Log("menü");
      
    }
    private void OnSettingsClick(ClickEvent evt)
    {
        Debug.Log("settings");
        
        _backButton.style.display = DisplayStyle.Flex;
        _mainMenuButton.style.display = DisplayStyle.Flex;
        _soundButton.style.display = DisplayStyle.Flex;
        _vibrationButton.style.display = DisplayStyle.Flex;
        
    }
    private void OnMarketClick(ClickEvent evt)
    {
        Debug.Log("Market");
        _menuButton.style.display = DisplayStyle.Flex;
    }
    private void OnMarketBackClick(ClickEvent evt)
    {
        Debug.Log("marketback");
        _menuButton.style.display = DisplayStyle.None;
    }
    private void OnBackClick(ClickEvent evt)
    {
        Debug.Log("back");
        _backButton.style.display = DisplayStyle.None;
        _mainMenuButton.style.display = DisplayStyle.None;
        _soundButton.style.display = DisplayStyle.None;
        _vibrationButton.style.display = DisplayStyle.None;
     
    }

    private void OnMainMenuClick(ClickEvent evt)
    {
        Debug.Log("main menü");
        SceneManager.LoadScene(0);
    }
    
    private void OnSoundClick(ClickEvent evt)
    {
        Debug.Log("sound");
        if (_sound==0)
        {
            _soundButton.text = "Ses:Off";
            _sound = 1;
        }
        else if (_sound==1)
        {
            _soundButton.text = "Ses:On";
            _sound = 0;
        }
        
    }
    private void OnVibrationClick(ClickEvent evt)
    {
        Debug.Log("vibration");
        if (_vibration==0)
        {
            _vibrationButton.text = "Titreşim:Off";
            _vibration = 1;
        }
        else if (_vibration==1)
        {
            _vibrationButton.text = "Titreşim:On";
            _vibration = 0;
        }
        
    }
}
