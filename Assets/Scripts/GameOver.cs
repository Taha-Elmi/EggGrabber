using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{

    public Text state;
    public GameObject friedEgg;
    
    private SpriteRenderer FriedEggSpriteRenderer;

    private void OnCollisionEnter2D(Collision2D other)
    {
        state.text = "3";
        FriedEggSpriteRenderer = friedEgg.GetComponent<SpriteRenderer>();
        FriedEggSpriteRenderer.enabled = true;
    }

    private void Update()
    {
        if (state.text.Equals("3"))
        {
            if (friedEgg.transform.localScale.x < 1.6f) ;
                    {
                        friedEgg.transform.localScale += new Vector3(0.2f * Time.deltaTime, 0.2f * Time.deltaTime, 0);
                        Debug.Log(friedEgg.transform.localScale.x.ToString());
                    }
        }
        
    }
}
