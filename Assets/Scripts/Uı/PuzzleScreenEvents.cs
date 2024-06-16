
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
public class PuzzleScreenEvents : MonoBehaviour
{

    private UIDocument _document;
 
 
    private Button _settingsButton;
 
    
    private Button _soundButton;
    private Button _vibrationButton;
    private Button _backButton;
    private Button _mainMenuButton;

    
    private int _sound = 0;
    private int _vibration = 0;
    
    private void Awake()
    {
        _document = GetComponent<UIDocument>();
        
        _settingsButton = _document.rootVisualElement.Q("Ayarlar") as Button;
     
        
        _backButton = _document.rootVisualElement.Q("Back") as Button;
        _mainMenuButton = _document.rootVisualElement.Q("Anamenu") as Button;
        _soundButton = _document.rootVisualElement.Q("Sound") as Button;
        _vibrationButton = _document.rootVisualElement.Q("Vibration") as Button;
        
   
        
        _settingsButton.RegisterCallback<ClickEvent>(OnSettingsClick);
       
        
        _backButton.RegisterCallback<ClickEvent>(OnBackClick);
        _mainMenuButton.RegisterCallback<ClickEvent>(OnMainMenuClick);
        _soundButton.RegisterCallback<ClickEvent>(OnSoundClick);
        _vibrationButton.RegisterCallback<ClickEvent>(OnVibrationClick);
        

    }

 

    private void OnDisable()
    {

        _settingsButton.UnregisterCallback<ClickEvent>(OnSettingsClick);
     
        
        _backButton.UnregisterCallback<ClickEvent>(OnBackClick);
        _mainMenuButton.UnregisterCallback<ClickEvent>(OnMainMenuClick);
        _soundButton.UnregisterCallback<ClickEvent>(OnSoundClick);
        _vibrationButton.UnregisterCallback<ClickEvent>(OnVibrationClick);
        


    }
 
    private void OnSettingsClick(ClickEvent evt)
    {
        Debug.Log("settings");
        Camera.main.GetComponent<DragAndDrop>().isPause = true;
        _backButton.style.display = DisplayStyle.Flex;
        _mainMenuButton.style.display = DisplayStyle.Flex;
        _soundButton.style.display = DisplayStyle.Flex;
        _vibrationButton.style.display = DisplayStyle.Flex;
        
    }

    private void OnBackClick(ClickEvent evt)
    {
        Debug.Log("back");
        Camera.main.GetComponent<DragAndDrop>().isPause = false;
        _backButton.style.display = DisplayStyle.None;
        _mainMenuButton.style.display = DisplayStyle.None;
        _soundButton.style.display = DisplayStyle.None;
        _vibrationButton.style.display = DisplayStyle.None;
     
    }

    private void OnMainMenuClick(ClickEvent evt)
    {
        Debug.Log("main menü");
        Camera.main.GetComponent<DragAndDrop>().isPause = false;
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
