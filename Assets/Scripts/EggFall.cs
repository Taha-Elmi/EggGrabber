using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;
using Random = UnityEngine.Random;

public class EggFall : MonoBehaviour
{
    private int eggNumber;
    private GameObject egg;
    private GameObject parrentEgg;
    private float delayTime;

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
        
        if (egg)
        {
            egg.SetActive(true);
            Debug.Log(eggName);
        }
        else
        {
            Debug.Log("Nope:" + eggName);
        }
    }

    private void Update()
    {
        delayTime -= Time.deltaTime;
        if (delayTime <= 0)
        {
            ActiveEgg();
            delayTime = 2;
        }
    }
}
