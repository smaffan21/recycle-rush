using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerScript_MainMenu : MonoBehaviour
{
    public GameObject[] spawnables;
    public DespawnerScript_FunFact despawnerScript;

    // Start is called before the first frame update
    public void Start()
    {
        activateSloMo();
        Application.targetFrameRate = 120;
        InvokeRepeating("SpawnObject", 0, 0.06f);
    }

    void SpawnObject() 
    {
        int chance = Random.Range(-1,90);
        float height = Random.Range(10,12);
        float tempPos = Random.Range(-2f, +2f);
        int randomRot = Random.Range(-200, 200);
        
        if (chance >= 0 && chance <= 21) { // plastic
            
            if (chance >= 0 && chance <= 10) 
            {
                Instantiate(spawnables[0], new Vector3(tempPos, height, 0), Quaternion.Euler(0,0,randomRot));
            }

            if (chance > 10 && chance <= 21) 
            {
                Instantiate(spawnables[1], new Vector3(tempPos, height, 0), Quaternion.Euler(0,0,randomRot));
            }      
        }

        if (chance > 21 && chance <= 42) { // paper
            
            if (chance > 21 && chance <= 31) 
            {
                Instantiate(spawnables[2], new Vector3(tempPos, height, 0), Quaternion.Euler(0,0,randomRot));
            }

            if (chance > 31 && chance <= 42) 
            {
                Instantiate(spawnables[3], new Vector3(tempPos, height, 0), Quaternion.Euler(0,0,randomRot));
            }
        }
        
        if (chance > 42 && chance <= 63) { // metal
            
            if (chance > 42 && chance <= 53) 
            {
                Instantiate(spawnables[4], new Vector3(tempPos, height, 0), Quaternion.Euler(0,0,randomRot));
            }

            if (chance > 53 && chance <= 63) 
            {
                Instantiate(spawnables[5], new Vector3(tempPos, height, 0), Quaternion.Euler(0,0,randomRot));
            }
        }

        if (chance > 63 && chance <= 84) { // glass
            
            if (chance > 63 && chance <= 73) 
            {
                Instantiate(spawnables[6], new Vector3(tempPos, height, 0), Quaternion.Euler(0,0,randomRot));
            }

            if (chance > 73 && chance <= 84) 
            {
                Instantiate(spawnables[7], new Vector3(tempPos, height, 0), Quaternion.Euler(0,0,randomRot));
            }
        }

        if (chance > 84 && chance <= 90) { // glass
        
            if (chance > 84 && chance <= 90) 
            {
                Instantiate(spawnables[8], new Vector3(tempPos, height, 0), Quaternion.Euler(0,0,randomRot));
            }
        }

    }

    void activateSloMo()
    {
        float speedFactor = Random.Range(0.5f,0.9f);
        Time.timeScale = speedFactor;
        Time.fixedDeltaTime = 0.02F * Time.timeScale;
    }
}
