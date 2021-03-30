using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;
using Random = UnityEngine.Random;

public class EggFall : MonoBehaviour
{
    private int eggNumber;
    private GameObject egg;
    private GameObject parrentEgg;
    private float delayTime = 2;
    private float timeHandler;
    private Vector3 eggPos;
    private int score;

    public Collider2D bowl;
    public Collider2D ground;
    public Text text;
    public Text state;
    public GameObject PauseMenu;
    

    private void ActiveEgg()
    {
        eggNumber = Random.Range(0, 56);
        String eggName = "Egg (" + eggNumber + ")";
        parrentEgg = GameObject.Find("Eggs");
        
        Transform[] trs= parrentEgg.GetComponentsInChildren<Transform>(true);
        foreach(Transform t in trs){
            if(t.name == eggName){
                egg = t.gameObject;
            }
        }

        eggPos = egg.transform.position;
        
        if (egg)
        {
            egg.SetActive(true);
        }
        else
        {
            //Debug.Log("Nope:" + eggName);
        }

    }

    private void EggLoop()
    {
        timeHandler -= Time.deltaTime;
        if (timeHandler <= 0)
        {
            ActiveEgg();
            timeHandler = delayTime;
            if (state.text.Equals("1"))
            {
                delayTime = Mathf.Clamp(2 - (score * 0.01f), 1.1f, 2);
            }
            else
            {
                delayTime = Mathf.Clamp(1.85f - (score * 0.01f), 1f, 2);
            }
            
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        other.gameObject.SetActive(false);
        other.gameObject.transform.position = eggPos;
        score++;
        text.text = ": " + score;
    }

    public void OnClick_Pause()
    {
        Time.timeScale = 0f;
        PauseMenu.SetActive(true);
    }

    private void Update()
    {
        if (state.text.Equals("1") || state.text.Equals("2"))
        {
            EggLoop();
        }
    }
}
