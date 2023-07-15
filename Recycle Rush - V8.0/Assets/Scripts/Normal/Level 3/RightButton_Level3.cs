using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RightButton_Level3 : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    bool isPressed = false;
    public GameObject Player;
    public float speed;
    public AudioSource src;
    public AudioClip binright;
    public DespawnerScript_Level3 ds;
    
    void Start()
    {
        speed = 5f;
    }
    void Update()
    {
        if (isPressed)
        {
            Player.transform.Translate(speed * Time.deltaTime, 0, 0);
        }

        if (ds.gameOverScreen.activeSelf)
        {
            src.Stop();
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        src.clip = binright; 
        src.pitch = src.pitch + 2;
        src.Play();
        isPressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        src.clip = binright; 
        src.pitch = src.pitch - 2;
        src.Stop();
        isPressed = false;
    }
}