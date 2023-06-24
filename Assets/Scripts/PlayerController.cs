using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class PlayerController : MonoBehaviour
{
    public float basespeed=3.0f;
    public float speed;
    public float speedup;

    public Text ScoreText;
    public Text GameOver;
    
    int Score=0;
    public GameObject[] lifeArray = new GameObject[10];
    private int lifePoint;

    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        basespeed = basespeed*0.001f;

        speed = basespeed;
        speedup=speed*2;

        audioSource=GetComponent<AudioSource>();

        ScoreText.text = "";
        Score = 0;
        lifePoint = 10;
        GameOver.enabled = false;

    }
    //SetActive(true)
    // Update is called once per frame
    void Update()
    {
        Vector2 position = transform.position;
        

        ScoreText.text = Mathf.Clamp(Score, 0, 99999999).ToString();
        

        if(GameOver.enabled == false)
        {
            if (position.x >= -4.5f)
                if (Input.GetKey(KeyCode.A))
                {
                    position.x -= speed;
                }

            if (position.x <= 4.5f)
                if (Input.GetKey(KeyCode.D))
                {
                    position.x += speed;
                }

            if (position.y <= 4.5f)
                if (Input.GetKey(KeyCode.W))
                {
                    position.y += speed;
                }

            if (position.y >= -4.5f)
                if (Input.GetKey(KeyCode.S))
                {
                    position.y -= speed;
                }

            if (Input.GetKey(KeyCode.Space))
            {
                speed = speedup;
            }
            else
            {
                speed = basespeed;
            }
        }
        

        if (lifePoint <= 0)
        {
            GameOver.enabled = true;
            transform.position = new Vector2(0, 0);
            //this.gameObject.SetActive(false);
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene("Title");
            }
        }
        if (lifePoint > 0)
        {
            Score += 123;
        }

        transform.position = position;

        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            other.gameObject.SetActive(false);
            Damage();
        }
    }

    private void Damage()
    {

        if (lifePoint > 0)
        {
            lifeArray[lifePoint - 1].SetActive(false);
            
        }
        lifePoint--;
    }


}
