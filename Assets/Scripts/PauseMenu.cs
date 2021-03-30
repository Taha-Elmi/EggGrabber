using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{

    public GameObject PauseMenuUI;
    public Text State;
    
    public void OnClick_Resume()
    {
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
    }

    public void OnClick_Quit()
    {
        Application.Quit();
    }
}
