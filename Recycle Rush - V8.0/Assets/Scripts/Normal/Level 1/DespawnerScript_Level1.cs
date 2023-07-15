using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DespawnerScript_Level1 : MonoBehaviour
{
    public GameObject h1, h2, h3;
    public GameObject gameOverScreen, buttons;

    [SerializeField]
    public int lives = 3;
    public PlayerScript_Level1 playerScript;

    private void OnTriggerEnter2D(Collider2D collision) // if recyclable hits ground, remove 1 life + remove recyclable
    {
        Destroy(collision.gameObject);    
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
                    gameOverScreen.SetActive(true);
                    buttons.SetActive(false);
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
