using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerScript_Level1 : MonoBehaviour
{
    public GameObject[] spawnables;
    public DespawnerScript_Level1 despawnerScript;
    public PlayerScript_Level1 playerScript;
    public Text text; 
    public Text incomingText;

    // Start is called before the first frame update
    public void Start()
    {
        Application.targetFrameRate = 120;
        InvokeRepeating("SpawnObject", 0.5f, 1.8f);
    }

    // Update is called once per frame
    void Update()
    {
        text.text = playerScript.score.ToString(); //displaying the score on the canvas

        if (despawnerScript.lives == 0) //if lives = 0, stop spawning
        {
            StopSpawning();
        }
    }

    void SpawnObject() 
    {
        int chance = Random.Range(-10,105);
        float height = Random.Range(10,11);
        float tempPos = Random.Range(-1.9f, +1.9f);
        

        if (chance >= -10 && chance <= 40) { // plastic
            
            if (chance >= 10 && chance <= 20) 
            {
                Instantiate(spawnables[0], new Vector3(tempPos, height, 0), Quaternion.identity);
                incomingText.text = "Incoming: Plastic Bag";
            }

            if (chance > 20 && chance <= 40) 
            {
                Instantiate(spawnables[1], new Vector3(tempPos, height, 0), Quaternion.identity);
                incomingText.text = "Incoming: Plastic Straws";
            }      
        }

        if (chance > 40 && chance <= 60) { // paper
            
            if (chance > 40 && chance <= 50) 
            {
                Instantiate(spawnables[2], new Vector3(tempPos, height, 0), Quaternion.identity);
                incomingText.text = "Incoming: Paper Ball";
            }

            if (chance > 50 && chance <= 60) 
            {
                Instantiate(spawnables[3], new Vector3(tempPos, height, 0), Quaternion.identity);
                incomingText.text = "Incoming: Newspapers";
            }
        }
        
        if (chance > 60 && chance <= 80) { // metal
            
            if (chance > 60 && chance <= 70) 
            {
                Instantiate(spawnables[4], new Vector3(tempPos, height, 0), Quaternion.identity);
                incomingText.text = "Incoming: Tin Can";
            }

            if (chance > 70 && chance <= 80) 
            {
                Instantiate(spawnables[5], new Vector3(tempPos, height, 0), Quaternion.identity);
                incomingText.text = "Incoming: Soda Can";
            }
        }

        if (chance > 80 && chance <= 100) { // glass
            
            if (chance > 80 && chance <= 90) 
            {
                Instantiate(spawnables[6], new Vector3(tempPos, height, 0), Quaternion.identity);
                incomingText.text = "Incoming: Glass Bottle";
            }

            if (chance > 90 && chance <= 100) 
            {
                Instantiate(spawnables[7], new Vector3(tempPos, height, 0), Quaternion.identity);
                incomingText.text = "Incoming: Glass Bottle";
            }
        }

        if (chance > 100 && chance <= 105) { // glass
            
            Instantiate(spawnables[8], new Vector3(tempPos, height, 0), Quaternion.identity);
            incomingText.text = "Incoming: Burger!";
        }
    }

    public void StopSpawning() 
    {
        CancelInvoke();
    }

}
