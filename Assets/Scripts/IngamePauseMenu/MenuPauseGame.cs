using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuPauseGame : MonoBehaviour
{

    public GameObject pauseMenu;
    public GameObject mainUI;

    public void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            PauseGame();
        }
    }

    public void PauseGame()
    {
        pauseMenu.SetActive(true);
        mainUI.SetActive(false);
        Time.timeScale = 0.0f;
    }
}
