using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerScript_Level4 : MonoBehaviour
{
    [SerializeField]
    float speed;
    public int score = 0;
    public DespawnerScript_Level4 despawnerScript;

    public AudioSource src;
    public AudioClip scoreUp, error, powerup;
    private void OnTriggerEnter2D(Collider2D collision) // if object hits player, add/subtract 1 score
    {
        if (collision.tag == "BlueBottle" || collision.tag == "GreenBottle") 
        {
            src.clip = scoreUp; 
            src.Play();

            score += 1;
            Destroy(collision.gameObject);
        }

        else if (collision.tag == "PaperBall" || collision.tag == "Papers" || collision.tag == "Soda1" || collision.tag == "Soda2" || collision.tag == "Bag" || collision.tag == "Straws") 
        {
            src.clip = error; 
            src.Play();

            despawnerScript.lives -= 1;
            Destroy(collision.gameObject);
        }

        else if (collision.tag == "Heart") 
        {
            src.clip = powerup; 
            src.Play();
            
            despawnerScript.lives += 1;
            Destroy(collision.gameObject);
        }

        else if (collision.tag == "SlowMo") 
        {
            src.clip = powerup; 
            src.Play();

            Destroy(collision.gameObject);
            StartCoroutine(SlowMo());
        }
    }
    IEnumerator SlowMo()
    {
        Time.timeScale = 0.5f;
        Time.fixedDeltaTime = 0.02F * Time.timeScale;
        yield return new WaitForSecondsRealtime(5);
        Time.timeScale = 1;
    }

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow)) 
        {
            transform.Translate(new Vector3 (1,0,0) * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftArrow)) 
        {
            transform.Translate(new Vector3 (-1,0,0) * speed * Time.deltaTime);
        }

        float currentXPos = transform.position.x;
        currentXPos = Mathf.Clamp(currentXPos, -1.8f, +1.8f);
        transform.position = new Vector3(currentXPos, transform.position.y, transform.position.z);
        
        nextLevelCheck();
    }

    public void nextLevelCheck() 
    {   
        if (score == 15) // next level validity check
        {
            int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(9);
            SceneManager.UnloadSceneAsync(8);
        }
    }
}
