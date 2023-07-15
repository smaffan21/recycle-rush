using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManagerScript : MonoBehaviour
{
    public GameObject gameManager, buttons, topPanel, levelInfoScreen, skipButton, pauseMenu, startScreen;
    public static bool GameIsPaused = false;


    // Start is called before the first frame update
    void Start()
    {
        buttons.SetActive(false);
        topPanel.SetActive(false);
        startScreen.SetActive(false);
    }

    public void skipLevelInfoScreen() // skip level info screen
    {
        levelInfoScreen.SetActive(false);
        topPanel.SetActive(true);
        skipButton.SetActive(false);
        buttons.SetActive(true);
        startScreen.SetActive(true);
    }

    public void pauseButton() 
    {
        Time.timeScale = 0;
        buttons.SetActive(false);
        pauseMenu.SetActive(true);
        GameIsPaused = true;
    }

    public void resumeButton() 
    {
        Time.timeScale = 1;
        buttons.SetActive(true);
        pauseMenu.SetActive(false);
        GameIsPaused = false;
    }

    public void resetTimeScale() 
    {
        Time.timeScale = 1;
    }
    public void startButton() 
    {
        startScreen.SetActive(false);
        gameManager.SetActive(true);
    }
}
