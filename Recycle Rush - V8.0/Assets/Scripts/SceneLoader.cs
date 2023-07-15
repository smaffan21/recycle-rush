using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadMenu() 
    {
        ResetTime();
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadSceneAsync("MainMenu");
        SceneManager.UnloadSceneAsync(currentSceneIndex);
        Time.timeScale = 1;
    }

    public void RestartLevel() 
    {
        ResetTime();        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }   

    public void LoadArcadeMode() 
    {
        ResetTime();
        SceneManager.LoadScene("ArcadeMode");
        SceneManager.UnloadSceneAsync("MainMenu");
    }

    public void RetryArcadeMode() 
    {
        ResetTime();
        SceneManager.LoadScene("ArcadeMode");
        SceneManager.UnloadSceneAsync("ArcadeSummary");
    }

    public void LoadNormalMode() 
    {
        ResetTime();
        SceneManager.LoadSceneAsync("Level1");
        SceneManager.UnloadSceneAsync("MainMenu");
    }

    public void LoadArcadeSummary() 
    {
        ResetTime();
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.UnloadSceneAsync(currentSceneIndex);
        SceneManager.LoadSceneAsync("ArcadeSummary");
    }

    public void LoadFunFact() 
    {
        ResetTime();
        SceneManager.LoadSceneAsync("FunFact");
        SceneManager.UnloadSceneAsync("MainMenu");
    }
    public void LoadKWHInfo()
    {
        ResetTime();
        SceneManager.LoadSceneAsync("KWHInfo");
        SceneManager.UnloadSceneAsync("ArcadeSummary");
    }
    void ResetTime() 
    {
        Time.timeScale = 1;
        Time.fixedDeltaTime = 0.02F;
    }
}
