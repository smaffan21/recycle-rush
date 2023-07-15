using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerScript : MonoBehaviour
{
    public GameObject[] spawnables;
    public DespawnerScript despawnerScript;
    public PlayerScript playerScript;
    public GameObject startScreen;
    public Text text;
    public Text incomingText;

    // Start is called before the first frame update
    public void Start()
    {
        Application.targetFrameRate = 120;
        InvokeRepeating("SpawnObject", 1f, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        text.text = playerScript.score.ToString(); //displaying the score on the canvas

        if (despawnerScript.lives == 0) //if lives = 0, stop spawning
        {
            playerScript.UpdateHighscoreText();
            StopSpawning();
        }
    }
    void SpawnObject() 
    {
        int chance = Random.Range(0,100);
        float height = Random.Range(10,11);
        float tempPos = Random.Range(-1.9f, +1.9f);
        

        if (chance >= 0 && chance <= 21) { // plastic
            
            if (chance >= 0 && chance <= 10) 
            {
                Instantiate(spawnables[0], new Vector3(tempPos, height, 0), Quaternion.identity);
                incomingText.text = "Incoming: Plastic Bag";
            }

            if (chance > 10 && chance <= 21) 
            {
                Instantiate(spawnables[1], new Vector3(tempPos, height, 0), Quaternion.identity);
                incomingText.text = "Incoming: Plastic Straws";
            }      
        }

        if (chance > 21 && chance <= 42) { // paper
            
            if (chance > 21 && chance <= 31) 
            {
                Instantiate(spawnables[2], new Vector3(tempPos, height, 0), Quaternion.identity);
                incomingText.text = "Incoming: Paper Ball";
            }

            if (chance > 31 && chance <= 42) 
            {
                Instantiate(spawnables[3], new Vector3(tempPos, height, 0), Quaternion.identity);
                incomingText.text = "Incoming: Newspapers";
            }
        }
        
        if (chance > 42 && chance <= 63) { // metal
            
            if (chance > 42 && chance <= 53) 
            {
                Instantiate(spawnables[4], new Vector3(tempPos, height, 0), Quaternion.identity);
                incomingText.text = "Incoming: Tin Can";
            }

            if (chance > 53 && chance <= 63) 
            {
                Instantiate(spawnables[5], new Vector3(tempPos, height, 0), Quaternion.identity);
                incomingText.text = "Incoming: Soda Can";
            }
        }

        if (chance > 63 && chance <= 84) { // glass
            
            if (chance > 63 && chance <= 73) 
            {
                Instantiate(spawnables[6], new Vector3(tempPos, height, 0), Quaternion.identity);
                incomingText.text = "Incoming: Glass Bottle";
            }

            if (chance > 73 && chance <= 84) 
            {
                Instantiate(spawnables[7], new Vector3(tempPos, height, 0), Quaternion.identity);
                incomingText.text = "Incoming: Glass Bottle";
            }
        }

        else if (chance > 84 && chance <= 92.5) { // heart
            Instantiate(spawnables[8], new Vector3(tempPos, height, 0), Quaternion.identity);
            incomingText.text = "Incoming: BOMB";
        }

        else if (chance > 92.5 && chance <= 95) { // bomb
            Instantiate(spawnables[9], new Vector3(tempPos, height, 0), Quaternion.identity);
            incomingText.text = "Incoming: Powerup";
        }
        
        else if (chance > 95 && chance <= 97.5) { // binspeed powerup
            Instantiate(spawnables[10], new Vector3(tempPos, height, 0), Quaternion.identity);
            incomingText.text = "Incoming: Powerup";
        }

        else if (chance > 97.5 && chance <= 100) { // shield powerup
            Instantiate(spawnables[11], new Vector3(tempPos, height, 0), Quaternion.identity);
            incomingText.text = "Incoming: Powerup";
        }
    }

    void StopSpawning() 
    {
        CancelInvoke();
    }
}