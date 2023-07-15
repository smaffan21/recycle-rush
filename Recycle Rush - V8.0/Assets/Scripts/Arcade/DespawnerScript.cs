using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DespawnerScript : MonoBehaviour
{
    public GameObject h1, h2, h3;
    public GameObject gameOverScreen, buttons;
    public SceneLoader sceneLoader;
    
    [SerializeField]
    public int lives = 3;

    private void OnTriggerEnter2D(Collider2D collision) // if recyclable hits ground, remove 1 life + remove recyclable
    {
        if (collision.tag == "Bomb" || collision.tag == "Heart" || collision.tag == "IncreaseBinSpeed" || collision.tag == "Shield") 
        {
            Destroy(collision.gameObject);
        }

        else
        {
            lives -= 1;
            Destroy(collision.gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        gameOverScreen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        switch(lives) {

            case 0: h1.SetActive(false);
                    h2.SetActive(false);
                    h3.SetActive(false);
                    sceneLoader.LoadArcadeSummary();
                    PlayerScript.energySaved = PlayerScript.plastickWH + PlayerScript.paperkWH + PlayerScript.metalkWH + PlayerScript.glasskWH;
                    break;
            case 1: h1.SetActive(false);
                    h2.SetActive(false);
                    h3.SetActive(true);
                    break;
            case 2: h1.SetActive(false);
                    h2.SetActive(true);
                    h3.SetActive(true);
                    break;
            case 3: h1.SetActive(true);
                    h2.SetActive(true);
                    h3.SetActive(true);
                    gameOverScreen.SetActive(false);
                    break;
        }
    }
}
