using System;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public Timer Timmer;
    public piceseScript piece1;
    public piceseScript piece2;
    public piceseScript piece3;
    public piceseScript piece4;
    
    public TextMeshProUGUI WinText;
    public TextMeshProUGUI LoseText;
    public Button MainMenu;



    private void Start()
    {
       Timmer= Timmer.gameObject.GetComponent<Timer>();
       piece1 = piece1.gameObject.GetComponent<piceseScript>();
       piece1 = piece2.gameObject.GetComponent<piceseScript>();
       piece1 = piece3.gameObject.GetComponent<piceseScript>();
       piece1 = piece4.gameObject.GetComponent<piceseScript>();
    }

    private void Update()
    {
        if (Timmer.timer==0)
        {
            loseGame();
            Debug.Log("Kayıp ettin");
        }

        if (piece1.InRightPosition==true&&piece2.InRightPosition==true&&piece3.InRightPosition==true&&piece4.InRightPosition==true)
        {
            winGame();
            Debug.Log("Kazandın");
        }
    
    }

    private void winGame()
    {
        WinText.gameObject.SetActive(true);
        MainMenu.gameObject.SetActive(true);
    }

    private void loseGame()
    {
        LoseText.gameObject.SetActive(true);
        MainMenu.gameObject.SetActive(true);
    }
    public void mainMenu()
    {
        Debug.Log("sa");
        SceneManager.LoadScene(1);
    }
}
