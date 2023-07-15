using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class StartScreenScript : MonoBehaviour
{
    public GameObject startScreen, gameManager;
    bool isSkipped = false; 
    // Start is called before the first frame update
    void Start()
    {
        startScreen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(gameManager.activeSelf) 
        {
            startScreen.SetActive(true);
        }

        if(isSkipped)
        {
            startScreen.SetActive(false);
        }
    }
    
    public void OnPointerDown(PointerEventData eventData)
    {
        isSkipped = true;
    }
}
