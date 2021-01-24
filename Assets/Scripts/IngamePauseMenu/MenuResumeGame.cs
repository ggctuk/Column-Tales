using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuResumeGame : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject mainUI;

    public void OnClick()
    {
        Time.timeScale = 1.0f;
        pauseMenu.SetActive(false);
        mainUI.SetActive(true);
    }
}
