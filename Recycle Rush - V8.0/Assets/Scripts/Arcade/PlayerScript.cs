using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{
    [SerializeField]
    float speed = 5f;
    public int score = 0;
    public DespawnerScript despawnerScript;
    public GameManagerScript gameManagerScript;
    public Text highScoreText;
    public Text shieldText;
    public GameObject powerupBox;
    public Text binSpeedText;
    private bool bombOff = false;
    public LeftButton lb;
    public RightButton rb;
    public AudioSource src;
    public AudioClip bin1, bin2, scoreUp, error, bombExplode, shield1, shield2, powerup;
    
    public static float 
        bagAmt = 5.6f, 
        bottleAmt = 170f, 
        paperballAmt = 0.8f, 
        papersAmt = 13f, 
        sodaAmt = 7f,
        strawsAmt = 0.5f;

    public static float plastickWH = 0, metalkWH = 0, paperkWH = 0, glasskWH = 0;
    public static float energySaved = 0f;

    private void OnTriggerEnter2D(Collider2D collision) // if object hits player, add/subtract 1 score
    {

        if (collision.tag == "Bag" || collision.tag == "BlueBottle" || collision.tag == "GreenBottle"|| collision.tag == "PaperBall" || 
        collision.tag == "Papers" || collision.tag == "Soda1" || collision.tag == "Soda2" || collision.tag == "Straws") 
        {
            src.clip = scoreUp; 
            src.Play();
            
            if (score < 50) 
            {
                score += 1;
            }
            else if (score >= 50) 
            {
                score += 2;
            }
            else if (score >= 100) 
            {
                score += 3;
            }
            else if (score >= 200 && score <= 400) 
            {
                score += 4;
            }
            else
            {
                score += 5;
            }
            
            Destroy(collision.gameObject);
            CheckHighscore();
            StartCoroutine(GameSpeed());

            if(collision.tag == "Bag")
            {
                plastickWH += bagAmt;
            }

            else if(collision.tag == "Straws")
            {
                plastickWH += strawsAmt;
            }


            if(collision.tag == "BlueBottle" || collision.tag == "GreenBottle")
            {
                glasskWH += bottleAmt;
            }


            if(collision.tag == "Soda1" || collision.tag == "Soda2")
            {
                metalkWH += sodaAmt;
            }

            if(collision.tag == "PaperBall")
            {
                paperkWH += paperballAmt;
            }

            else if(collision.tag == "Papers")
            {
                paperkWH += papersAmt;
            }            
        }

        else if (collision.tag == "Bomb" && !bombOff) 
        {
            src.clip = bombExplode; 
            src.Play();
            despawnerScript.lives -= 1;
            Destroy(collision.gameObject);
        }

        else if (collision.tag == "Bomb" && bombOff) 
        {
            Destroy(collision.gameObject);

            int soundPlayed = Random.Range(0,1);
            
            switch(soundPlayed) 
            {
                case 0: src.clip = shield1; src.Play(); break;
                case 1: src.clip = shield2; src.Play(); break;
            }
        }

        else if (collision.tag == "Heart") 
        {
            src.clip = powerup; 
            src.Play();

            if (despawnerScript.lives >= 3) {
                Destroy(collision.gameObject);
            }

            else {
                Destroy(collision.gameObject);
                despawnerScript.lives += 1;
            }
        }

        else if (collision.tag == "IncreaseBinSpeed") 
        {
            src.clip = powerup; 
            src.Play();
            Destroy(collision.gameObject);
            StartCoroutine(IncreaseBinSpeed());
        }

        else if (collision.tag == "Shield") 
        {
            src.clip = powerup; 
            src.Play();

            Destroy(collision.gameObject);
            StartCoroutine(Shield());
        }
    }

    IEnumerator Shield()
    {
        powerupBox.SetActive(true);
        shieldText.text = $"Bomb Shield Active!";
        bombOff = true;
        yield return new WaitForSecondsRealtime(5);
        bombOff = false;
        shieldText.text = "";
        powerupBox.SetActive(false);

        if (speed == 5f) 
        {
            powerupBox.SetActive(false);
        }
    }
    
    IEnumerator IncreaseBinSpeed()
    {
        powerupBox.SetActive(true);
        binSpeedText.text = $"Increased Bin Speed!";
        speed = 7f;
        lb.speed = -7f;
        rb.speed = 7f;
        yield return new WaitForSecondsRealtime(7);
        speed = 5f;
        lb.speed = -5f;
        rb.speed = 5f;
        binSpeedText.text = "";

        if (bombOff == false) 
        {
            powerupBox.SetActive(false);
        }
    }
    IEnumerator GameSpeed()
    {
        if(score == 10 || score == 25 || score == 50 || score == 75 || score == 100 || score == 150
            || score == 175 || score == 200 || score == 250 || score == 300 || score == 500
            || score == 700 || score == 850 || score == 1000 || score == 1500 || score == 2000) 
        {
            Time.timeScale = Time.timeScale + 0.1f;
            print(Time.timeScale);
        }

        yield return new WaitForSecondsRealtime(3);
    }

    private void CheckHighscore() 
    {
        if (score > PlayerPrefs.GetInt("Highscore", 0)) 
        {
            PlayerPrefs.SetInt("Highscore", score);
        }
    }

    public void UpdateHighscoreText() 
    {
        highScoreText.text = $"Highscore: {PlayerPrefs.GetInt("Highscore", 0)}";
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
    }
}