using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public GameObject chef;
    public GameObject MenuUI;
    public GameObject GameUI;
    public Text State;
    public Text BestNormal;
    public Text BestHard;
    public Button Normal;
    public Button Hard;

    private int bestNormal;
    private int bestHard;
    private void Start()
    {
        bestNormal = PlayerPrefs.GetInt("normal");
        bestHard = PlayerPrefs.GetInt("hard");
        BestNormal.text = "Best: " + bestNormal;
        BestHard.text = "Best: " + bestHard;
    }

    public void OnClick_Play()
    {
        MenuUI.SetActive(false);
        GameUI.SetActive(true);
        chef.SetActive(true);
        Time.timeScale = 1f;
    }

    public void OnClick_Hard()
    {
        Hard.interactable = false;
        Normal.interactable = true;
        State.text = "2";
    }
    
    public void OnClick_Normal()
    {
        Normal.interactable = false;
        Hard.interactable = true;
        State.text = "1";
    }
}
