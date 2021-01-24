using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ExitToTitle : MonoBehaviour
{
    public string mainTitleScene;

    public void OnClick()
    {
        SceneManager.LoadScene(mainTitleScene);
        Time.timeScale = 1.0f;
    }
}
