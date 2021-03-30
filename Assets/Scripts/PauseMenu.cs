using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{

    public GameObject PauseMenuUI;
    public GameObject MenuUI;
    public Text State;
    
    public void OnClick_Resume()
    {
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
    }

    public void OnClick_Menu()
    {
        PauseMenuUI.SetActive(false);
        MenuUI.SetActive(true);
        State.text = "3";
    }
    
    public void OnClick_Quit()
    {
        Application.Quit();
    }
}
