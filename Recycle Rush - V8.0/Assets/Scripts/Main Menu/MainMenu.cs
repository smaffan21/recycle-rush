using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    public void playButtonSound()
    {
        audioSource.Play();
    }   

    // Update is called once per frame
    void Update()
    {       
        
    }

    public void ExitButton() // Quit Game (Main Menu)
    {
        Application.Quit();
    }
    public void FunFactButton() // Quit Game (Main Menu)
    {
        
    }
    
}
