using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuRestartScene : MonoBehaviour
{
    public string levelName;

    public void OnClick()
    {
        SceneManager.LoadScene(levelName);
        Time.timeScale = 1.0f;
    }
}
