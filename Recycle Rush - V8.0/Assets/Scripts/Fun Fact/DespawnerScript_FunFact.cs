using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DespawnerScript_FunFact : MonoBehaviour
{    
    [SerializeField]

    private void OnTriggerEnter2D(Collider2D collision) // if recyclable hits ground, remove 1 life + remove recyclable
    {
        Destroy(collision.gameObject);
    }
}
