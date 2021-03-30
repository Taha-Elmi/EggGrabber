using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class GameOver : MonoBehaviour
{

    public Text state;
    public Text score;
    public GameObject friedEgg;
    public VideoPlayer Gooz;
    public AudioSource AudioSource;
    public GameObject GameUI;
    public GameObject MenuUI;
    public Text BestNormal;
    public Text BestHard;

    private SpriteRenderer FriedEggSpriteRenderer;

    private void Start()
    {
        Time.timeScale = 0f;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Gooz.Play();
        AudioSource.Play();
        Time.timeScale = 0;
        
        other.gameObject.SetActive(false);
        score.text = ": 0";

        /*int intScore = int.Parse(score.text);
        int best;
        switch (state.text)
        {
            case "1":
                best = PlayerPrefs.GetInt("normal");
                if (intScore > best)
                {
                    PlayerPrefs.SetInt("normal", intScore);
                    BestNormal.text = "Best: " + intScore;
                }
                else
                {
                    BestNormal.text = "Best: " + best;
                }
                
                break;
            case "2":
                best = PlayerPrefs.GetInt("hard");
                if (intScore > best)
                {
                    PlayerPrefs.SetInt("hard", intScore);
                    BestHard.text = "Best: " + intScore;
                }
                else
                {
                    BestHard.text = "Best: " + best;
                }
                break;
        }*/

        GameUI.SetActive(false);
        MenuUI.SetActive(true);
        
        //FriedEggSpriteRenderer = friedEgg.GetComponent<SpriteRenderer>();
        //FriedEggSpriteRenderer.enabled = true;
    }

    private void Update()
    {
        if (state.text.Equals("3"))
        {
            /*if (friedEgg.transform.localScale.x < 1.6f) ;
            {
                friedEgg.transform.localScale += new Vector3(0.2f * Time.deltaTime, 0.2f * Time.deltaTime, 0);
                Debug.Log(friedEgg.transform.localScale.x.ToString());
            }*/
        }
        
    }
}
